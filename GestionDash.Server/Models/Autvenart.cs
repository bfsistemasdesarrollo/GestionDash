using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Autvenart
{
    public short TmovCod { get; set; }

    public int AutMovNro { get; set; }

    public short AutArtLin { get; set; }

    public string AutArtLote { get; set; } = null!;

    public string AutArtReceta { get; set; } = null!;

    public int AutArtNro { get; set; }

    public short AutArtIva { get; set; }

    public decimal AutArtCan { get; set; }

    public decimal AutArtPrecio { get; set; }

    public decimal AutArtImpu { get; set; }

    public decimal AutArtNeto { get; set; }

    public string AutArtDet { get; set; } = null!;

    public string AutArtEntre { get; set; } = null!;

    public decimal AutArtPorDto { get; set; }

    public short AutDepNro { get; set; }

    public decimal? AutArtPreLis { get; set; }

    public int? AutForCod { get; set; }

    public string? AutForEst { get; set; }

    public string? AutArtRecInt { get; set; }

    public string? AutRecResp { get; set; }
}
