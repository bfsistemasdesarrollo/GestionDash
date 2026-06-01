using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Empresa
{
    public short EmpCod { get; set; }

    public string EmpDir { get; set; } = null!;

    public string EmpTel { get; set; } = null!;

    public string EmpMail { get; set; } = null!;

    public short EmpMonBase { get; set; }

    public string EmpNom { get; set; } = null!;

    public string EmpFax { get; set; } = null!;

    public string EmpWww { get; set; } = null!;

    public short EmpRep { get; set; }

    public string EmpAlogo { get; set; } = null!;

    public string EmpTlogo { get; set; } = null!;

    public DateTime EmpFeCie { get; set; }

    public string EmpNota { get; set; } = null!;

    public string EmpNotEc { get; set; } = null!;

    public short EmpPlim { get; set; }

    public decimal EmpRedMn { get; set; }

    public decimal EmpRedMe { get; set; }

    public short EmpTred { get; set; }

    public short EmpClfrm { get; set; }

    public short EmpIvaIn { get; set; }

    public string EmpTfs { get; set; } = null!;

    public int EmpArtNro { get; set; }

    public string EmpRut { get; set; } = null!;

    public DateTime EmpFeInv { get; set; }

    public short EmpSinMov { get; set; }

    public string EmpImpCdo { get; set; } = null!;

    public string EmpImpCre { get; set; } = null!;

    public string EmpImpRec { get; set; } = null!;

    public string EmpNotEc2 { get; set; } = null!;

    public decimal EmpIntMpe { get; set; }

    public decimal EmpIntMdo { get; set; }

    public int EmpArtInt { get; set; }

    public DateTime? EmpFeCaja { get; set; }

    public DateTime EmpFeCos { get; set; }

    public string EmpMmail { get; set; } = null!;

    public short EmpMtiem { get; set; }

    public string EmpMnom { get; set; } = null!;

    public string EmpMusu { get; set; } = null!;

    public string EmpMser { get; set; } = null!;

    public string EmpMpass { get; set; } = null!;

    public decimal EmpCupon { get; set; }

    public string EmpImpRem { get; set; } = null!;

    public DateTime EmpDesCup { get; set; }

    public DateTime EmpHasCup { get; set; }

    public short EmpPtoCup { get; set; }

    public string? EmpMmailcopia { get; set; }

    public string? EmpMmailRespuesta { get; set; }

    public string? EmpBduserId { get; set; }

    public string? EmpBdpassword { get; set; }

    public string? EmpBddataSource { get; set; }

    public string? EmpBdinitialCatalog { get; set; }

    public string? EmpCenCos { get; set; }

    public string? EmpConSuc { get; set; }

    public string EmpParAdic { get; set; } = null!;

    public decimal? EmpCodigo { get; set; }

    public string? EmpPk { get; set; }

    public string EmpClaveAcc { get; set; } = null!;

    public string? EmpHost { get; set; }

    public string? EmpBaseUrl { get; set; }

    public string? EmpResolAutDgi { get; set; }

    public string? EmpCarpetaQr { get; set; }

    public string? EmiCiudad { get; set; }

    public string? EmiComercial { get; set; }

    public string? EmiCorreoEmisor { get; set; }

    public string? EmiDepartamento { get; set; }

    public string? EmiDomFiscal { get; set; }

    public string? EmiGiroEmis { get; set; }

    public string? EmiRznSoc { get; set; }

    public string? EmiSucursal { get; set; }

    public string? EmiTelefono { get; set; }

    public string? EmiTelefono2 { get; set; }

    public decimal EmiMontoMinimo { get; set; }

    public DateTime? EmpCfefechaValorUi { get; set; }

    public string? EmpCfecontingencia { get; set; }

    public string? EmpWsEmisionFactura { get; set; }

    public string? EmpWsConsultaFactura { get; set; }

    public string? EmpWsAnulacionFactura { get; set; }

    public string? EmpWsConsultaRecibidos { get; set; }

    public string? EmpWsDescargaRecibidos { get; set; }

    public string? EmpWsAceptacionRecibidos { get; set; }

    public string? EmpAplicaDto { get; set; }

    public short? EmpCantDtoA { get; set; }

    public decimal? EmpPorDtoA { get; set; }

    public short? EmpCantDtoB { get; set; }

    public decimal? EmpPorDtoB { get; set; }

    public string? EmpWappUrl { get; set; }

    public string? EmpWappHost { get; set; }

    public short? EmpMaut { get; set; }

    public short? EmpMsec { get; set; }

    public short? EmpMport { get; set; }
}
