using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Pronota
{
    public int ProNro { get; set; }

    public short ProNotaNro { get; set; }

    public string ProTipoNota { get; set; } = null!;

    public string ProNotaEst { get; set; } = null!;

    public string ProNotaDet { get; set; } = null!;

    public DateTime ProNotaFpen { get; set; }

    public short ProNotaUsu { get; set; }

    public DateTime ProNotaFech { get; set; }
}
