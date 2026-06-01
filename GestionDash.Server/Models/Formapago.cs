using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Formapago
{
    public short ForPagNro { get; set; }

    public string ForPagDes { get; set; } = null!;

    public string ForPagTip { get; set; } = null!;

    public string ForPagGen { get; set; } = null!;

    public short? ForPagDcod { get; set; }

    public string ForPagPos { get; set; } = null!;

    public string ForPagAct { get; set; } = null!;

    public string ForPagEsp { get; set; } = null!;

    public string ForPagRec { get; set; } = null!;

    public string ForPagCdo { get; set; } = null!;

    public string ForPagCre { get; set; } = null!;

    public string? ForRubCod { get; set; }
}
