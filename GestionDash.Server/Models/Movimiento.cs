using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Movimiento
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public string? MovDocu { get; set; }

    public DateTime MovFch { get; set; }

    public DateTime MovVence { get; set; }

    public string MovNota { get; set; } = null!;

    public short? MovMonCod { get; set; }

    public decimal MovCot { get; set; }

    public decimal MovTotal { get; set; }

    public short MovEstado { get; set; }

    public string? MovRubCod { get; set; }

    public short? MovImpCod { get; set; }

    public decimal MovImpu { get; set; }

    public short MovUltLin { get; set; }

    public short MovUltPro { get; set; }

    public short MovCantLin { get; set; }

    public int MovCliNro { get; set; }

    public int MovProNro { get; set; }

    public string MovRemito { get; set; } = null!;

    public short MovUsuCod { get; set; }

    public DateTime MovFchIng { get; set; }

    public short? MovVenUsu { get; set; }

    public string MovPasado { get; set; } = null!;

    public short MovCuotas { get; set; }

    public short MovPeriodo { get; set; }

    public short MovUltDoc { get; set; }

    public short? MovForPnro { get; set; }

    public decimal MovTotSal { get; set; }

    public short? PagoMonCod { get; set; }

    public decimal? PagoImporte { get; set; }

    public string MovEvCont { get; set; } = null!;

    public string? MovOrden { get; set; }

    public decimal MovTotDto { get; set; }

    public short? MovLisPreNro { get; set; }

    public string MovAutCp { get; set; } = null!;

    public string MovEstAut { get; set; } = null!;

    public short? MovAutUsu { get; set; }

    public decimal MovTotFac { get; set; }

    public short? MovUsuFac { get; set; }

    public string MovAut1 { get; set; } = null!;

    public string MovAut2 { get; set; } = null!;

    public string MovAut3 { get; set; } = null!;

    public int? MovAutNro { get; set; }

    public string? MovNomCli { get; set; }

    public string? MovPenRec { get; set; }

    public decimal? MovTotDebe { get; set; }

    public decimal? MovTotHaber { get; set; }

    public short? MovSucCod { get; set; }

    public short MovGenRet { get; set; }

    public string? MovFiscal { get; set; }

    public string? MovSecCod { get; set; }

    public string? MovOrdInt { get; set; }

    public string? MovSsecCod { get; set; }

    public string? MovHoraEst { get; set; }

    public string? MovFletePen { get; set; }

    public string? MovCenCosC { get; set; }

    public string? MovDirEnvio { get; set; }

    public string? MovDirCob { get; set; }

    public string? MovLocalidad { get; set; }

    public string? MovTelOri { get; set; }

    public string? MovResponsable { get; set; }

    public string? MovOriGen { get; set; }

    public DateTime? MovFchEnt { get; set; }

    public decimal? MovCaenro { get; set; }

    public DateTime? MovCaevencimiento { get; set; }

    public string? MovCaerango { get; set; }

    public string? MovCfeserie { get; set; }

    public int? MovCfenro { get; set; }

    public string? MovCfecodSeguridad { get; set; }

    public short? MovCfecodigo { get; set; }

    public short? MovCfeestado { get; set; }

    public short? MovCfeestadoAcuse { get; set; }

    public string? MovCferepImpresa { get; set; }

    public int? RepartoNro { get; set; }
}
