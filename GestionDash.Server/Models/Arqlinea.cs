using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Arqlinea
{
    public DateTime ArqFecha { get; set; }

    public short ArqSucCod { get; set; }

    public short ArqMonCod { get; set; }

    public short ArqLinea { get; set; }

    public short ArqBilNro { get; set; }

    public int ArqCant { get; set; }
}
