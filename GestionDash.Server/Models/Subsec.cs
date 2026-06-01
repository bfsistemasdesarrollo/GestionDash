using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Subsec
{
    public string SecNro { get; set; } = null!;

    public string SubSecNro { get; set; } = null!;

    public string SubSecDes { get; set; } = null!;

    public string? SubSrubCc { get; set; }

    public string? SubSrubVc { get; set; }

    public string SubSecStock { get; set; } = null!;

    public string SubSecLis { get; set; } = null!;

    public string? SubSecNota { get; set; }

    public short? SubSecOpe { get; set; }
}
