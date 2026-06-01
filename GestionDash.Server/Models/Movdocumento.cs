using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Movdocumento
{
    public short TmovCod { get; set; }

    public int MovNro { get; set; }

    public short MovDocLin { get; set; }

    public short MovDocTipo { get; set; }

    public DateTime MovDocFecha { get; set; }

    public short MovDocMon { get; set; }

    public decimal MovDocImp { get; set; }

    public string MovDocNro { get; set; } = null!;

    public string MovDocNota { get; set; } = null!;

    public string MovDocEst { get; set; } = null!;
}
