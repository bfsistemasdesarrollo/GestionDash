using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Articulo
{
    public int ArtNro { get; set; }

    public string ArtDes { get; set; } = null!;

    public string ArtCodigo { get; set; } = null!;

    public string ArtCodBar { get; set; } = null!;

    public string ArtEstado { get; set; } = null!;

    public short ArtMonCod { get; set; }

    public short ArtImpCod { get; set; }

    public string ArtInven { get; set; } = null!;

    public string ArtReceta { get; set; } = null!;

    public string ArtRedondeo { get; set; } = null!;

    public decimal ArtPuntos { get; set; }

    public string ArtLista { get; set; } = null!;

    public decimal ArtStock { get; set; }

    public short ArtDepCod { get; set; }

    public string ArtNota { get; set; } = null!;

    public decimal ArtStkMin { get; set; }

    public string ArtSecNro { get; set; } = null!;

    public string ArtSsecNro { get; set; } = null!;

    public short ArtLabNro { get; set; }

    public short ArtUniCod { get; set; }

    public decimal ArtPreCosto { get; set; }

    public decimal ArtPreFlete { get; set; }

    public string ArtModValor { get; set; } = null!;

    public string ArtEsDto { get; set; } = null!;

    public decimal ArtCos30 { get; set; }

    public decimal ArtCosInv { get; set; }

    public decimal ArtEquiv { get; set; }

    public string ArtPresen { get; set; } = null!;

    public DateTime ArtVence { get; set; }

    public DateTime ArtVen2 { get; set; }

    public string ArtConVta { get; set; } = null!;

    public decimal ArtUniCan { get; set; }

    public string ArtLibre { get; set; } = null!;

    public short ArtEsFormula { get; set; }

    public short ArtRetImp { get; set; }

    public short? ArtCosOpeC { get; set; }

    public decimal ArtPrePond { get; set; }

    public short ArtEsComponente { get; set; }

    public short ArtEsMedicamento { get; set; }

    public short? ArtConLote { get; set; }
}
