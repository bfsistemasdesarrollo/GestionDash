using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Marca
{
    public short MarcaCod { get; set; }

    public string MarcaNom { get; set; } = null!;
}
