using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Prosaldo
{
    public int ProNro { get; set; }

    public short ProMonCod { get; set; }

    public decimal ProSaldo { get; set; }

    public int ProNroAnt { get; set; }
}
