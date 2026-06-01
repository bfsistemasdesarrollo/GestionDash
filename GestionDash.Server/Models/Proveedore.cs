using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Proveedore
{
    public int ProNro { get; set; }

    public string ProNom { get; set; } = null!;

    public string ProRazSoc { get; set; } = null!;

    public string ProRut { get; set; } = null!;

    public string ProDir { get; set; } = null!;

    public short ProLocCod1 { get; set; }

    public string ProDir2 { get; set; } = null!;

    public short ProLocCod2 { get; set; }

    public string ProContacto { get; set; } = null!;

    public string ProTel { get; set; } = null!;

    public string ProTel2 { get; set; } = null!;

    public string ProMail { get; set; } = null!;

    public string ProCel { get; set; } = null!;

    public string ProTipoCta { get; set; } = null!;

    public short ProTipoMon { get; set; }

    public DateTime ProFecIng { get; set; }

    public DateTime ProFecUlt { get; set; }

    public DateTime ProFecAut { get; set; }

    public DateTime ProFecPago { get; set; }

    public short ProUsuCod { get; set; }

    public string ProActivo { get; set; } = null!;

    public short ProUltNota { get; set; }

    public string ProComen { get; set; } = null!;

    public decimal ProDtoP { get; set; }

    public decimal ProDtoD { get; set; }

    public short ProDias { get; set; }

    public int? ProNroRel { get; set; }

    public short ProPrIva { get; set; }

    public short ProDiaCie { get; set; }

    public short ProDiaCie2 { get; set; }

    public short? ProIvaInc { get; set; }

    public string? ProCedula { get; set; }
}
