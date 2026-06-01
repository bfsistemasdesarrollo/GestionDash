using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Impuesto
{
    public short ImpCod { get; set; }

    public string ImpDes { get; set; } = null!;

    public string ImpDesCor { get; set; } = null!;

    public string ImpEsIva { get; set; } = null!;

    public string ImpRubCcod { get; set; } = null!;

    public string ImpRubVcod { get; set; } = null!;

    public decimal ImpTasaActual { get; set; }

    public string? ImpRubVco { get; set; }

    public string? ImpRubVcr { get; set; }

    public string? ImpRubCc { get; set; }

    public int? ImpArtNro { get; set; }

    public string ImpExpAsim { get; set; } = null!;

    public short ImpIndFac { get; set; }
}
