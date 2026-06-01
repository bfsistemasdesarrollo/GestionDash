using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Impuestos1
{
    public short ImpCod { get; set; }

    public DateTime ImpFecha { get; set; }

    public decimal ImpTasa { get; set; }

    public decimal ImpTaPor { get; set; }
}
