using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Forinven
{
    public int ForCod { get; set; }

    public short ForInvDepNro { get; set; }

    public DateTime ForInvDepFch { get; set; }

    public decimal ForInvStkReal { get; set; }

    public decimal ForInvStkPen { get; set; }
}
