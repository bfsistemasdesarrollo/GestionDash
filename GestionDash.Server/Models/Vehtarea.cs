using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Vehtarea
{
    public short VehCod { get; set; }

    public short TarCod { get; set; }

    public string TarDes { get; set; } = null!;

    public string TarTipo { get; set; } = null!;

    public int TarFreKm { get; set; }

    public int TarFreHr { get; set; }

    public short TarFreTi { get; set; }
}
