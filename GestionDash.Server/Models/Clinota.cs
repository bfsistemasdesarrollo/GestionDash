using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Clinota
{
    public int CliNro { get; set; }

    public short CliNotaNro { get; set; }

    public DateTime CliNotaFecha { get; set; }

    public string CliNotaTipo { get; set; } = null!;

    public string CliNotaEst { get; set; } = null!;

    public string CliAutNom { get; set; } = null!;

    public string CliAutCed { get; set; } = null!;

    public string CliNotaDet { get; set; } = null!;

    public DateTime CliNotaFpen { get; set; }

    public short CliNotaUsu { get; set; }

    public string CliNotaAut { get; set; } = null!;
}
