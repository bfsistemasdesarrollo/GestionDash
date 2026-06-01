using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Unidade
{
    public short UniCod { get; set; }

    public string UniDesChi { get; set; } = null!;

    public string UniDes { get; set; } = null!;
}
