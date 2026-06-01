using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Saldorubro
{
    public string SalRubCod { get; set; } = null!;

    public DateTime SalRubFecha { get; set; }

    public short SalSucCod { get; set; }

    public decimal SalRubDol { get; set; }

    public decimal SalRubPesos { get; set; }

    public decimal SalTodoPesos { get; set; }

    public decimal SalTodoDol { get; set; }

    public decimal SalDolPesos { get; set; }

    public decimal SalPesosDol { get; set; }
}
