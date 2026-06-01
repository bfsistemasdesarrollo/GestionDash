using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Cobrador
{
    public short CobNro { get; set; }

    public string CobNom { get; set; } = null!;

    public string CobDir { get; set; } = null!;

    public string CobTel { get; set; } = null!;

    public string CobCel { get; set; } = null!;

    public decimal CobPorcen { get; set; }
}
