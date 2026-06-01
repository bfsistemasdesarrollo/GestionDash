using System;
using System.Collections.Generic;

namespace GestionDash.Server.Models;

public partial class Laboratorio
{
    public short LabNro { get; set; }

    public string LabNombre { get; set; } = null!;

    public short LabCupon { get; set; }

    public string LabNomAnt { get; set; } = null!;
}
