using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Forregistro
{
    public int ForRegArt { get; set; }

    public int ForRegNro { get; set; }

    public DateTime ForRegFecha { get; set; }

    public string ForRegAct { get; set; } = null!;

    public string ForRegNota { get; set; } = null!;

    public DateTime? ForRegVence { get; set; }
}
