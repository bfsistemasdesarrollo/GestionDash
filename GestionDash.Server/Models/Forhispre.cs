using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Forhispre
{
    public int ForCod { get; set; }

    public DateTime ForFePrecio { get; set; }

    public short ForFeLin { get; set; }

    public decimal ForCosto { get; set; }

    public decimal ForCosFlete { get; set; }

    public decimal ForPreCon { get; set; }

    public decimal ForPreCre1 { get; set; }

    public decimal ForPreCre2 { get; set; }

    public decimal ForPreConEsp { get; set; }
}
