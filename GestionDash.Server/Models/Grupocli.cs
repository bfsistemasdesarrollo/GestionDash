using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Grupocli
{
    public short GrupoNro { get; set; }

    public string GrupoNombre { get; set; } = null!;

    public string GrupoDirec { get; set; } = null!;

    public string GrupoTel { get; set; } = null!;

    public string GrupoMail { get; set; } = null!;

    public string GrupoTel2 { get; set; } = null!;

    public string GrupoContacto { get; set; } = null!;

    public string GrupoNota { get; set; } = null!;

    public short GrupoMon { get; set; }

    public decimal GrupoTope { get; set; }
}
