using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Movrubro
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovLin { get; set; }

    public string MrubCod { get; set; } = null!;

    public DateTime MovLinFch { get; set; }

    public DateTime MovLinVen { get; set; }

    public string MovLinNot { get; set; } = null!;

    public decimal MovLinTot { get; set; }

    public string MovLinDh { get; set; } = null!;

    public decimal? MovLinIva { get; set; }
}
