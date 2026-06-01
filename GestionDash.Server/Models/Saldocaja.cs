using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Saldocaja
{
    public DateTime SalCaFecha { get; set; }

    public short SucCod { get; set; }

    public decimal SalCaDol { get; set; }

    public decimal SalCaPesos { get; set; }
}
