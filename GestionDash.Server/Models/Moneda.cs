using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Moneda
{
    public short MonCod { get; set; }

    public string MonSim { get; set; } = null!;

    public string MonDes { get; set; } = null!;

    public decimal CotVigente { get; set; }

    public DateTime CotFecVig { get; set; }

    public string? MonCodFe { get; set; }
}
