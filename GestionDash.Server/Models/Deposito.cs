using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Deposito
{
    public short DepNro { get; set; }

    public string DepDes { get; set; } = null!;

    public string DepDirec { get; set; } = null!;

    public string DepTel { get; set; } = null!;

    public string DepAcEnt { get; set; } = null!;

    public short DepFtoImp { get; set; }

    public string DepForImp { get; set; } = null!;

    public short? DepSucCod { get; set; }
}
