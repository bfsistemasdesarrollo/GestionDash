using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Lisprecio
{
    public short LisPreNro { get; set; }

    public string LisPreDes { get; set; } = null!;

    public string LisPreTipo { get; set; } = null!;

    public decimal LisPrePor { get; set; }

    public short LisPrePlazo { get; set; }

    public string LisPreAut { get; set; } = null!;

    public decimal LisPreMas { get; set; }

    public decimal LisPreMen { get; set; }

    public short LisPreLista { get; set; }

    public string LisPreTit { get; set; } = null!;

    public string LisPreCon { get; set; } = null!;

    public string LisPreEsp { get; set; } = null!;

    public decimal LisPrePesp { get; set; }
}
