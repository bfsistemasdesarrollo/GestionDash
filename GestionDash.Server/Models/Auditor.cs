using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Auditor
{
    public int AudNro { get; set; }

    public string? AudTipo { get; set; }

    public string? AudNota { get; set; }

    public DateTime? AudFecha { get; set; }

    public string? AudHora { get; set; }

    public short AudUsuCod { get; set; }

    public int? AudMovNro { get; set; }

    public decimal? AudValor { get; set; }

    public short? AudTmovCod { get; set; }

    public int? AudCta { get; set; }

    public decimal? AudValAnt { get; set; }

    public string? AudEvento { get; set; }

    public string? AudPrograma { get; set; }

    public short? AudMonCod { get; set; }

    public DateTime? AudMovFch { get; set; }

    public string? AudTipCta { get; set; }

    public short? AudUsuMov { get; set; }

    public DateTime? AudFchIng { get; set; }

    public string? AudRubro { get; set; }
}
