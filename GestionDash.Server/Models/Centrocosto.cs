using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Centrocosto
{
    public string CenCosCod { get; set; } = null!;

    public string CenCosDes { get; set; } = null!;

    public string CenCosPar { get; set; } = null!;

    public string CenCosEst { get; set; } = null!;

    public string CenCosNota { get; set; } = null!;
}
