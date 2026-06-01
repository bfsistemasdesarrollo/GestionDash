using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Control
{
    public string CtrlPc { get; set; } = null!;

    public string CtrlBf { get; set; } = null!;

    public short CtrlLic { get; set; }

    public string CtrImpCdo { get; set; } = null!;

    public string CtrImpCre { get; set; } = null!;

    public string CtrImpRec { get; set; } = null!;

    public string? CtrImpRem { get; set; }
}
