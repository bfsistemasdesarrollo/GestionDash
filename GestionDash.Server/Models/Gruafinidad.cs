using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Gruafinidad
{
    public short GruAfiNro { get; set; }

    public string GruAfiNom { get; set; } = null!;

    public string GruAfiTel { get; set; } = null!;

    public string GruAfiCon { get; set; } = null!;

    public string GruAfiMail { get; set; } = null!;

    public string GruAfiNota { get; set; } = null!;

    public string GruAfiDir { get; set; } = null!;

    public string GruAfiActivo { get; set; } = null!;
}
