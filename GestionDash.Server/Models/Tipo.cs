using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Tipo
{
    public short TipoCod { get; set; }

    public string TipoNom { get; set; } = null!;

    public string TipoConTa { get; set; } = null!;
}
