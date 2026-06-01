using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Movstock
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovArtLin { get; set; }

    public DateTime MovArtFch { get; set; }

    public int MovArtNro { get; set; }

    public decimal MovArtCant { get; set; }

    public decimal MovArtIva { get; set; }

    public decimal MovArtPrecio { get; set; }

    public decimal MovArtNeto { get; set; }

    public decimal MovArtImpu { get; set; }

    public short MovDepNro { get; set; }

    public DateTime MovArtVen { get; set; }

    public string MovArtDet { get; set; } = null!;

    public string MovArtLote { get; set; } = null!;

    public string? MovArtReceta { get; set; }

    public string MovArtEntre { get; set; } = null!;

    public decimal MovArtPorDto { get; set; }

    public decimal MovArPrNeto { get; set; }

    public decimal? MovArtPreLis { get; set; }

    public decimal? MovRetPor { get; set; }

    public int? MovForCod { get; set; }

    public short? MovPlaUlin { get; set; }

    public string? MovForEst { get; set; }

    public string? MovRecInt { get; set; }

    public decimal? MovCantReal { get; set; }

    public string? MovRecResp { get; set; }
}
