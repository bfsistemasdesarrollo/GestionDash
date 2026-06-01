using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Cliente
{
    public int CliNro { get; set; }

    public string CliNom { get; set; } = null!;

    public string CliRazSoc { get; set; } = null!;

    public string CliRut { get; set; } = null!;

    public string CliDir { get; set; } = null!;

    public string CliTel { get; set; } = null!;

    public string CliMail { get; set; } = null!;

    public string CliCel { get; set; } = null!;

    public string CliDir2 { get; set; } = null!;

    public string CliContacto { get; set; } = null!;

    public string CliTel2 { get; set; } = null!;

    public short TipCliNro { get; set; }

    public string CliTipoTope { get; set; } = null!;

    public string CliTipoCta { get; set; } = null!;

    public DateTime CliFecIng { get; set; }

    public DateTime CliFecUlt { get; set; }

    public DateTime CliFecAut { get; set; }

    public short CliUsuCod { get; set; }

    public string CliActiva { get; set; } = null!;

    public short CliMonCod { get; set; }

    public short CliLisPre { get; set; }

    public string CliCedula { get; set; } = null!;

    public string CliInteres { get; set; } = null!;

    public short CliUltNota { get; set; }

    public short CliCobNro { get; set; }

    public short CliTipoMon { get; set; }

    public DateTime CliFecPago { get; set; }

    public decimal CliTope { get; set; }

    public short? CliGrupo { get; set; }

    public string PlazoCod { get; set; } = null!;

    public short TasaNro { get; set; }

    public short CliLocCod1 { get; set; }

    public short CliLocCod2 { get; set; }

    public string CliConforme { get; set; } = null!;

    public string CliAutor { get; set; } = null!;

    public string CliEnvMail { get; set; } = null!;

    public int? CliNroRel { get; set; }

    public short CliTipoDoc { get; set; }

    public string CliCcmail { get; set; } = null!;

    public string CliAdic { get; set; } = null!;

    public string CliEnvFacWapp { get; set; } = null!;
}
