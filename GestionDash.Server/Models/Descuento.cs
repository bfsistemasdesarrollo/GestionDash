using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Descuento
{
    public short DesCod { get; set; }

    public string DesDes { get; set; } = null!;

    public decimal DesPorcen { get; set; }

    public string DesGral { get; set; } = null!;

    public int? DesArtNro { get; set; }
}
