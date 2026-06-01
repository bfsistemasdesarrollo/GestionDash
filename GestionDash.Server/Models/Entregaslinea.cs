using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Entregaslinea
{
    public int EntDoc { get; set; }

    public short EntNoLin { get; set; }

    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovArtLin { get; set; }

    public decimal EntCan { get; set; }

    public string? EntLote { get; set; }
}
