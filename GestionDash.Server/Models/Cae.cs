using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Cae
{
    public decimal Caenro { get; set; }

    public short Caecfetipo { get; set; }

    public string Caeserie { get; set; } = null!;

    public int CaenroDesde { get; set; }

    public int CaenroHasta { get; set; }

    public DateTime Caevencimiento { get; set; }

    public string Caeestado { get; set; } = null!;

    public string Caestandard { get; set; } = null!;

    public int? CaeultNumero { get; set; }
}
