using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Grupo
{
    public short SgruCod { get; set; }

    public string SgruDes { get; set; } = null!;

    public short? SgruSucCod { get; set; }
}
