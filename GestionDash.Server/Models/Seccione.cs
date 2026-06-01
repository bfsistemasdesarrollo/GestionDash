using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Seccione
{
    public string SecNro { get; set; } = null!;

    public string SecDes { get; set; } = null!;

    public string SecStock { get; set; } = null!;

    public string? SecRubCcod { get; set; }

    public string? SecRubVcod { get; set; }
}
