using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Codigocfe
{
    public short Cfecodigo { get; set; }

    public string Cfedesc { get; set; } = null!;

    public string Cfeconting { get; set; } = null!;
}
