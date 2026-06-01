using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Artprecio
{
    public int ArtNro { get; set; }

    public short ArtLisPreNro { get; set; }

    public decimal ArtPrecio { get; set; }

    public decimal ArtLisPor { get; set; }

    public decimal ArtLporAct { get; set; }

    public DateTime? ArtLisFePre { get; set; }

    public decimal ArtPreAnt { get; set; }
}
