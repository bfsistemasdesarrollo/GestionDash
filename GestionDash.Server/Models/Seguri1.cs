using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Seguri1
{
    public short SgruCod { get; set; }

    public string SproCod { get; set; } = null!;

    public string SeveNom { get; set; } = null!;

    public string SeveAut { get; set; } = null!;

    public DateTime? SeveHasta { get; set; }
}
