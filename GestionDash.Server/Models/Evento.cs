using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Evento
{
    public string SproCod { get; set; } = null!;

    public string SeveNom { get; set; } = null!;

    public string SeveDes { get; set; } = null!;

    public string SeveDoble { get; set; } = null!;

    public string SeveAud { get; set; } = null!;
}
