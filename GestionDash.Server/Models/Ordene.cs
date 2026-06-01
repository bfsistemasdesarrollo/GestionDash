using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Ordene
{
    public int OrdNro { get; set; }

    public int? OrdNroBatch { get; set; }

    public int? OrdArtNro { get; set; }

    public string? OrdArtDes { get; set; }

    public decimal? OrdSetPoint { get; set; }

    public int? Orden { get; set; }

    public string? OrdDes { get; set; }

    public DateTime OrdInicio { get; set; }

    public DateTime? OrdFin { get; set; }

    public decimal? OrdKg { get; set; }

    public int? OrdForCod { get; set; }

    public string? OrdForDes { get; set; }

    public string? OrdTipoCarga { get; set; }

    public short OrdTolNro { get; set; }

    public int? OrdForArtNro { get; set; }

    public decimal? OrdForComCant { get; set; }

    public string? OrdForArtDes { get; set; }

    public DateTime? OrdFecha { get; set; }
}
