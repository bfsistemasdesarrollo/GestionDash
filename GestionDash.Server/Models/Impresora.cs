using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Impresora
{
    public string ImpFor { get; set; } = null!;

    public string ImpNota { get; set; } = null!;

    public string ImpTip { get; set; } = null!;

    public int ImpNroPre { get; set; }

    public string ImpNroSer { get; set; } = null!;

    public short ImpVias { get; set; }

    public string ImpTipNro { get; set; } = null!;

    public short? ImpSucCod { get; set; }
}
