using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Tipcli
{
    public short TipCliNro { get; set; }

    public string TipCliDes { get; set; } = null!;

    public short? TipCliSuc { get; set; }
}
