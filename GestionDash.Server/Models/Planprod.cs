using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Planprod
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovArtLin { get; set; }

    public short MovPlaLin { get; set; }

    public DateTime MovPlaFecha { get; set; }

    public DateTime MovPlaCarga { get; set; }

    public DateTime MovPlaCarFin { get; set; }

    public decimal MovPlaKgs { get; set; }

    public decimal MovPlaKgsReal { get; set; }

    public string MovPlaEstado { get; set; } = null!;

    public string MovPlaTrans { get; set; } = null!;

    public string MovPlaNota { get; set; } = null!;

    public string? MovPlaHora { get; set; }

    public int? MovPlaProCod { get; set; }
}
