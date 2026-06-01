using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Billete
{
    public short BilNro { get; set; }

    public string BilDesc { get; set; } = null!;

    public int BilValor { get; set; }

    public string BilActivo { get; set; } = null!;

    public short BilMonedas { get; set; }
}
