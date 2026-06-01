using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Zona
{
    public short ZonasCodigo { get; set; }

    public string ZonasDescripcion { get; set; } = null!;

    public short LocCod { get; set; }
}
