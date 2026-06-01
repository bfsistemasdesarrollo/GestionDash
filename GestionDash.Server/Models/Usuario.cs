using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Usuario
{
    public short UsuCod { get; set; }

    public string UsuNom { get; set; } = null!;

    public string UsuCla { get; set; } = null!;

    public string UsuIngSis { get; set; } = null!;

    public string UsuPerm { get; set; } = null!;

    public short SgruCod { get; set; }

    public string UsuNomLar { get; set; } = null!;

    public string UsuNotPen { get; set; } = null!;

    public string? UsuVende { get; set; }

    public string? UsuCamPre { get; set; }

    public string? UsuExtra { get; set; }

    public string? UsuVeTodo { get; set; }

    public string? UsuAdic { get; set; }

    public string UsuMail { get; set; } = null!;
}
