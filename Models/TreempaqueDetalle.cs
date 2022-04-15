using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class TreempaqueDetalle
    {
        public decimal NCodigoReempaqueDetalle { get; set; }
        public decimal? NCodigoReempaque { get; set; }
        public int? NPalete { get; set; }
        public int? NCantidadCajas { get; set; }
        public double? FPeso { get; set; }
        public string? CMedidas { get; set; }
        public double? FPesoActual { get; set; }
        public double? FPesoVolumen { get; set; }
        public double? FPesoCobrable { get; set; }
        public double? FCbm { get; set; }

        public virtual Treempaque? NCodigoReempaqueNavigation { get; set; }
    }
}
