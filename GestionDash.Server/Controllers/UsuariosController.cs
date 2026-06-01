using GestionDash.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionDash.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly AppDbContext _db;

    public UsuariosController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var usuarios = await _db.Usuarios
            .Select(u => new
            {
                u.UsuCod,
                u.UsuNom,
                u.UsuNomLar,
                u.UsuMail,
                u.SgruCod
            })
            .ToListAsync();

        return Ok(usuarios);
    }
}
