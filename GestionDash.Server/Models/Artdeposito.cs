using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Artdeposito
{
    public int ArtNro { get; set; }

    public short ArtDnro { get; set; }

    public string ArtDact { get; set; } = null!;

    public decimal ArtDstkIni { get; set; }
}
