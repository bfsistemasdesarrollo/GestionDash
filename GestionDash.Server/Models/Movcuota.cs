using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Movcuota
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovCuoLin { get; set; }

    public DateTime MovCuoVen { get; set; }

    public int MovCuoCta { get; set; }

    public decimal MovCuoImp { get; set; }
}
