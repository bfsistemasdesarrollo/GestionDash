using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class HistorialEliminado
{
    public int Id { get; set; }

    public string? Tabla { get; set; }

    public string? Datos { get; set; }

    public DateTime? FechaEliminacion { get; set; }

    public string? Usuario { get; set; }
}
