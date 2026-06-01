using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Autventa
{
    public short TmovCod { get; set; }

    public int AutMovNro { get; set; }

    public DateTime AutMovFch { get; set; }

    public DateTime AutMovVen { get; set; }

    public string AutMovNota { get; set; } = null!;

    public string AutMovDocu { get; set; } = null!;

    public string AutMovOrden { get; set; } = null!;

    public string AutMovRem { get; set; } = null!;

    public short AutMonCod { get; set; }

    public decimal AutMovCot { get; set; }

    public decimal AutMovTotal { get; set; }

    public string AutMovEst { get; set; } = null!;

    public string AutMovCp { get; set; } = null!;

    public short? AutUsuAuC { get; set; }

    public int AutCliNro { get; set; }

    public short AutUltPro { get; set; }

    public short AutCantLin { get; set; }

    public short? AutLisPreNro { get; set; }

    public short AutUsuCod { get; set; }

    public short AutUsuVen { get; set; }

    public DateTime AutFchIng { get; set; }

    public short AutCuotas { get; set; }

    public short AutPeriodo { get; set; }

    public string AutMot1 { get; set; } = null!;

    public string AutMot2 { get; set; } = null!;

    public string AutMot3 { get; set; } = null!;

    public short? AutUsuFac { get; set; }

    public DateTime AutFchAut { get; set; }

    public short AutForPnro { get; set; }

    public int AutNroFac { get; set; }

    public decimal AutTotFac { get; set; }

    public string? AutImpresora { get; set; }

    public short? AutSucCod { get; set; }

    public string? AutCenCosC { get; set; }

    public string? AutDirEnvio { get; set; }

    public string? AutDirCobro { get; set; }

    public string? AutLocalidad { get; set; }

    public string? AutTelOri { get; set; }

    public string? AutResponsable { get; set; }

    public string? AutOriGen { get; set; }

    public DateTime? AutFchEnt { get; set; }

    public string? AutHorEnt { get; set; }
}
