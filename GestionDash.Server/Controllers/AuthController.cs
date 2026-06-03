using GestionDash.Server.Data;
using GestionDash.Server.DTOs;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace GestionDash.Server.Controllers;

// Ruta base: /api/auth
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // AppDbContext para consultar la tabla de usuarios en SQL Server
    private readonly AppDbContext _db;
    // IConfiguration para leer los valores de JWT desde appsettings.json
    private readonly IConfiguration _config;

    // Los servicios se inyectan automáticamente por el contenedor de dependencias de ASP.NET
    public AuthController(AppDbContext db, IConfiguration config)
    {
        _db = db;
        _config = config;
    }

    // POST /api/auth/login
    // Recibe email y contraseña en texto plano, los valida contra la BD y devuelve un JWT.
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        // Validación para que ninguno de los dos campos puede estar vacío
        if (string.IsNullOrWhiteSpace(request.UsuMail) || string.IsNullOrWhiteSpace(request.UsuCla))
            return BadRequest(new { message = "Usuario y contraseña son requeridos." });

        // La BD almacena los primeros 6 caracteres del MD5.
        var hashedPassword = HashMd5(request.UsuCla)[..6];

        // Busca el usuario que coincida exactamente en email Y contraseña hasheada
        var usuario = await _db.Usuarios
            .FirstOrDefaultAsync(u => u.UsuMail == request.UsuMail && u.UsuCla == hashedPassword);

        // Si no existe ninguna coincidencia, las credenciales son incorrectas
        if (usuario == null)
            return Unauthorized(new { message = "Credenciales incorrectas." });

        // Credenciales válidas: genera el JWT con los datos del usuario
        var token = GenerateJwtToken(usuario);

        // Devuelve el token y los datos del usuario que el frontend guardará en localStorage
        return Ok(new LoginResponse
        {
            Token      = token,
            UsuCod     = usuario.UsuCod,
            UsuNom     = usuario.UsuNom,
            UsuNomLar  = usuario.UsuNomLar,
            UsuMail    = usuario.UsuMail,
            SgruCod    = usuario.SgruCod
        });
    }

    // POST /api/auth/google
    // Valida el ID Token emitido por Google y devuelve un JWT si el email está registrado en la BD.
    [HttpPost("google")]
    public async Task<IActionResult> GoogleLogin([FromBody] GoogleLoginRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Credential))
            return BadRequest(new { message = "Token de Google requerido." });

        GoogleJsonWebSignature.Payload payload;
        try
        {
            var settings = new GoogleJsonWebSignature.ValidationSettings
            {
                Audience = new[] { _config["Google:ClientId"] }
            };
            payload = await GoogleJsonWebSignature.ValidateAsync(request.Credential, settings);
        }
        catch
        {
            return Unauthorized(new { message = "Token de Google inválido." });
        }

        if (!payload.EmailVerified)
            return Unauthorized(new { message = "La cuenta de Google no tiene el email verificado." });

        var usuario = await _db.Usuarios.FirstOrDefaultAsync(u => u.UsuMail == payload.Email);

        if (usuario == null)
            return Unauthorized(new { message = "Usuario no registrado." });

        var token = GenerateJwtToken(usuario);

        return Ok(new LoginResponse
        {
            Token     = token,
            UsuCod    = usuario.UsuCod,
            UsuNom    = usuario.UsuNom,
            UsuNomLar = usuario.UsuNomLar,
            UsuMail   = usuario.UsuMail,
            SgruCod   = usuario.SgruCod
        });
    }

    // Genera el hash MD5 de un string y lo devuelve en hexadecimal minúscula (32 chars).
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

    // Construye y firma el JWT que se enviará al frontend.
    // El token contiene los datos del usuario como claims y expira según appsettings.json.
    private string GenerateJwtToken(Models.Usuario usuario)
    {
        var jwt = _config.GetSection("Jwt"); // Lee Key, Issuer, Audience, ExpiryHours

        // La clave secreta debe tener al menos 256 bits para HMAC-SHA256
        var key         = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt["Key"]!));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expiry      = DateTime.UtcNow.AddHours(int.Parse(jwt["ExpiryHours"]!));

        // Claims: datos que viajan dentro del token y pueden leerse sin ir a la BD
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub,   usuario.UsuCod.ToString()), // ID del usuario
            new Claim(JwtRegisteredClaimNames.Email, usuario.UsuMail),
            new Claim(JwtRegisteredClaimNames.Jti,   Guid.NewGuid().ToString()), // ID único del token
            new Claim("usuNom",    usuario.UsuNom),
            new Claim("usuNomLar", usuario.UsuNomLar),
            new Claim("sgruCod",   usuario.SgruCod.ToString()) // grupo de seguridad del usuario
        };

        var token = new JwtSecurityToken(
            issuer:            jwt["Issuer"],
            audience:          jwt["Audience"],
            claims:            claims,
            expires:           expiry,
            signingCredentials: credentials
        );

        // Serializa el token al formato estándar: header.payload.signature (Base64URL)
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
