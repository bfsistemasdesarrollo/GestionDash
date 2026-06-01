using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Tipmov
{
    public short TmovCod { get; set; }

    public string TmovDes { get; set; } = null!;

    public short TmovSalRub { get; set; }

    public short TmovStock { get; set; }

    public string TmovLiqui { get; set; } = null!;

    public short TmovCaja { get; set; }

    public short TmovCon { get; set; }

    public string TmovCom { get; set; } = null!;

    public string TmovPrubV { get; set; } = null!;

    public short TmovAcc { get; set; }

    public string? NumTipo { get; set; }

    public string? RubFijoPcod { get; set; }

    public string? RubFijoDcod { get; set; }

    public string? RubVarPcod { get; set; }

    public string? RubVarDcod { get; set; }

    public string TmovFijoDh { get; set; } = null!;

    public string TmovTipo { get; set; } = null!;

    public short TmovConforme { get; set; }

    public string TmovFac { get; set; } = null!;

    public short? TmovRet { get; set; }
}
