using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Artstock
{
    public string ArtCodAnt { get; set; } = null!;

    public decimal ArtStkAnt { get; set; }

    public short ArtStkDep { get; set; }
}
