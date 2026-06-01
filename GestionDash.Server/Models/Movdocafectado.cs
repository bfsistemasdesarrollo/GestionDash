using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Movdocafectado
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovAfeCod { get; set; }

    public int MovAfeNro { get; set; }

    public decimal MovAfeImp { get; set; }
}
