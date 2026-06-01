using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Formula
{
    public int ForCod { get; set; }

    public string ForDes { get; set; } = null!;

    public decimal ForTot { get; set; }

    public decimal ForPre { get; set; }

    public decimal ForPrD { get; set; }

    public string ForAct { get; set; } = null!;

    public DateTime ForUltMod { get; set; }

    public int ForArtNro { get; set; }

    public short ForCosOpeC { get; set; }

    public string ForModValor { get; set; } = null!;

    public string? ForLisPrecio { get; set; }

    public short? ForTieneMed { get; set; }

    public string? ForEsBase { get; set; }

    public string? ForEquipo { get; set; }
}
