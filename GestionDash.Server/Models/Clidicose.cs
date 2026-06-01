using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Clidicose
{
    public int CliNro { get; set; }

    public string CliDicose { get; set; } = null!;

    public string CliDicNota { get; set; } = null!;

    public short CliDicLoc { get; set; }
}
