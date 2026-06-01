using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Preimpreso
{
    public int PreNro { get; set; }

    public int MovNro { get; set; }

    public short TmovCod { get; set; }

    public short PreCntFrm { get; set; }

    public short PreAnu { get; set; }

    public string PreNota { get; set; } = null!;

    public DateTime PreFch { get; set; }
}
