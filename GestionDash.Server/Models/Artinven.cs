using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Artinven
{
    public int ArtNro { get; set; }

    public short ArtDnro { get; set; }

    public DateTime ArtDfch { get; set; }

    public decimal ArtInvReal { get; set; }

    public decimal ArtInvPenEnt { get; set; }

    public decimal ArtInvPenRec { get; set; }
}
