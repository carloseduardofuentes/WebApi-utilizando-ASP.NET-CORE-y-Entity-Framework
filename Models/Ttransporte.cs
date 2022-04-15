using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Ttransporte
    {
        public int NCodigoTransporte { get; set; }
        public string CTransporte { get; set; } = null!;
        public string? CObservaciones { get; set; }
    }
}
