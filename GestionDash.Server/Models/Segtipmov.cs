using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Segtipmov
{
    public short SgruCod { get; set; }

    public short TmovCod { get; set; }

    public string TmovAut { get; set; } = null!;

    public string TmovDel { get; set; } = null!;

    public string TmovMod { get; set; } = null!;
}
