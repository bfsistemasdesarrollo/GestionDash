using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Forprecio
{
    public int ForCod { get; set; }

    public short ForLisPreNro { get; set; }

    public decimal ForPrePor { get; set; }

    public decimal ForPrecio { get; set; }

    public decimal ForPreAnt { get; set; }

    public DateTime ForPreFecha { get; set; }

    public decimal ForPrePorCal { get; set; }
}
