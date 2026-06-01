using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Matprima
{
    public short MatPriNro { get; set; }

    public string MatPriDes { get; set; } = null!;

    public string MatPriDchi { get; set; } = null!;
}
