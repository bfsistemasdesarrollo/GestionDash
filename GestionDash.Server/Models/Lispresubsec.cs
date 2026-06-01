using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Lispresubsec
{
    public short LisPreNro { get; set; }

    public string LisPreSec { get; set; } = null!;

    public string LisPreSubSec { get; set; } = null!;

    public decimal LisPreSecPor { get; set; }

    public decimal LisPreSecEsp { get; set; }
}
