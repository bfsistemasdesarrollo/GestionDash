using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Sucursale
{
    public short SucCod { get; set; }

    public string SucNom { get; set; } = null!;

    public DateTime SucFeCaja { get; set; }

    public short SucLinFac { get; set; }
}
