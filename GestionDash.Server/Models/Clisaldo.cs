using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Clisaldo
{
    public int CliNro { get; set; }

    public short CliSalMon { get; set; }

    public decimal CliSalAnt { get; set; }

    public int CliNroAnt { get; set; }

    public DateTime CliFecAtr { get; set; }
}
