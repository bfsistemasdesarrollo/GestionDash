using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Vehiculo
{
    public short VehCod { get; set; }

    public DateTime VehFecIng { get; set; }

    public short TipoCod { get; set; }

    public short MarcaCod { get; set; }

    public string VehDesc { get; set; } = null!;

    public short VehAnio { get; set; }

    public string VehColor { get; set; } = null!;

    public string VehNoMotor { get; set; } = null!;

    public string VehChasis { get; set; } = null!;

    public string VehCombus { get; set; } = null!;

    public string VehModelo { get; set; } = null!;

    public DateTime VehFecCom { get; set; }

    public int VehKmCom { get; set; }

    public DateTime VehFecGar { get; set; }

    public int VehKilGar { get; set; }

    public string VehObs { get; set; } = null!;

    public string VehTcont { get; set; } = null!;

    public int? VehOdoAct { get; set; }

    public int? VehHorAct { get; set; }

    public string VehMatAc { get; set; } = null!;

    public string VehNoInt { get; set; } = null!;

    public string VehEstado { get; set; } = null!;

    public string VehTman { get; set; } = null!;

    public string? VehUbDesc { get; set; }

    public string? VehUbMcol { get; set; }

    public short? VehUbMfil { get; set; }

    public DateTime VehUltSfe { get; set; }

    public decimal? VehCdesde { get; set; }

    public decimal? VehChasta { get; set; }
}
