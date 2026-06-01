using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Reparto
{
    public int RepartoNro { get; set; }

    public DateTime RepartoFecha { get; set; }

    public DateTime RepartoFechaEntrega { get; set; }

    public short? VehCod { get; set; }

    public short RepartoEstado { get; set; }

    public short RepZonasCodigo { get; set; }
}
