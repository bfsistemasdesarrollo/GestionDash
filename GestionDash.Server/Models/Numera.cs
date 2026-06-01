using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Numera
{
    public string NumTipo { get; set; } = null!;

    public int NumNro { get; set; }

    public short? NumCfetipoF { get; set; }

    public short? NumCfetipoT { get; set; }

    public short? NumCfetipoC { get; set; }

    public short? NumCfetipoCt { get; set; }
}
