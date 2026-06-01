using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Localidad
{
    public short LocCod { get; set; }

    public string LocNom { get; set; } = null!;

    public string? PaisCod { get; set; }

    public int? LocCp { get; set; }

    public string? LocDepartamento { get; set; }
}
