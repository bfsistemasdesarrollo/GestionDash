using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Entrega
{
    public int EntDoc { get; set; }

    public DateTime EntFec { get; set; }

    public string EntTip { get; set; } = null!;

    public DateTime EntFini { get; set; }

    public string EntHini { get; set; } = null!;

    public int CliNro { get; set; }

    public short UsuCod { get; set; }

    public short EntCantLin { get; set; }

    public short EntUltLin { get; set; }

    public string EntNota { get; set; } = null!;
}
