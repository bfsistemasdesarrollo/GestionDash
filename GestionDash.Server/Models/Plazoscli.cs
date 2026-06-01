using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Plazoscli
{
    public string PlazoCod { get; set; } = null!;

    public string PlazoDes { get; set; } = null!;

    public short PlazoDias { get; set; }
}
