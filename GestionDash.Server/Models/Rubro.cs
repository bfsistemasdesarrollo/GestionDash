using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Rubro
{
    public string RubCod { get; set; } = null!;

    public string RubNom { get; set; } = null!;

    public string RubExterno { get; set; } = null!;

    public short RubMonCod { get; set; }

    public string RubActivo { get; set; } = null!;

    public string RubTitulo { get; set; } = null!;

    public short? RubImpCod { get; set; }

    public short RubAsiDc { get; set; }
}
