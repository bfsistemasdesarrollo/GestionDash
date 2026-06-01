using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Costoope
{
    public short CosOpeCod { get; set; }

    public string CosOpeDes { get; set; } = null!;

    public decimal CosOpeVal { get; set; }

    public short CosOpeMon { get; set; }
}
