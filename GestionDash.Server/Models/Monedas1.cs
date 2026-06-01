using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Monedas1
{
    public short MonCod { get; set; }

    public DateTime CotFecha { get; set; }

    public decimal CotInter { get; set; }

    public decimal CotVenta { get; set; }

    public decimal CotCompra { get; set; }
}
