using GestionDash.Server.Data;
using GestionDash.Server.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GestionDash.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _db;
    private readonly IConfiguration _config;

    public AuthController(AppDbContext db, IConfiguration config)
    {
        _db = db;
        _config = config;
    }

    [HttpGet("debug/{email}")]
    public async Task<IActionResult> Debug(string email)
    {
        if (!HttpContext.RequestServices.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
            return NotFound();

        var usuario = await _db.Usuarios.FirstOrDefaultAsync(u => u.UsuMail == email);
        if (usuario == null)
            return NotFound(new { message = "Usuario no encontrado con ese mail." });

        var md5de1 = HashMd5("1");
        return Ok(new
        {
            usuMailEncontrado = usuario.UsuMail,
            usuClaAlmacenada = usuario.UsuCla,
            longitudUsuCla = usuario.UsuCla.Length,
            md5De1 = md5de1,
            coincide = usuario.UsuCla == md5de1,
            esTextoPlano1 = usuario.UsuCla == "1"
        });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.UsuMail) || string.IsNullOrWhiteSpace(request.UsuCla))
            return BadRequest(new { message = "Usuario y contraseña son requeridos." });

        var hashedPassword = HashMd5(request.UsuCla)[..6]; // Cortamos el hash generado para comparar con el almacenado en la BD.

        var usuario = await _db.Usuarios
            .FirstOrDefaultAsync(u => u.UsuMail == request.UsuMail && u.UsuCla == hashedPassword);

        if (usuario == null)
            return Unauthorized(new { message = "Credenciales incorrectas." });

        var token = GenerateJwtToken(usuario);

        return Ok(new LoginResponse
        {
            Token = token,
            UsuCod = usuario.UsuCod,
            UsuNom = usuario.UsuNom,
            UsuNomLar = usuario.UsuNomLar,
            UsuMail = usuario.UsuMail,
            SgruCod = usuario.SgruCod
        });
    }

    private static string HashMd5(string value)
    {
        var result = "";
        try
        {
            using var md5 = MD5.Create();
            var data = Encoding.UTF8.GetBytes(value);
            data = md5.ComputeHash(data);
            for (int i = 0; i < data.Length; i++)
                result += data[i].ToString("x2").ToLower();
        }
        catch { }
        return result;
    }

    private string GenerateJwtToken(Models.Usuario usuario)
    {
        var jwt = _config.GetSection("Jwt");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt["Key"]!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiry = DateTime.UtcNow.AddHours(int.Parse(jwt["ExpiryHours"]!));

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, usuario.UsuCod.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, usuario.UsuMail),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim("usuNom", usuario.UsuNom),
            new Claim("usuNomLar", usuario.UsuNomLar),
            new Claim("sgruCod", usuario.SgruCod.ToString())
        };

        var token = new JwtSecurityToken(
            issuer: jwt["Issuer"],
            audience: jwt["Audience"],
            claims: claims,
            expires: expiry,
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
