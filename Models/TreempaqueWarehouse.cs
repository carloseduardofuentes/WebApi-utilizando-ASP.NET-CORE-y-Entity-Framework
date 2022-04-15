using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class TreempaqueWarehouse
    {
        public decimal NCodigoReempaque { get; set; }
        public decimal NCodigoWarehouse { get; set; }
        public int? NCantidadCajas { get; set; }
        public double? FPeso { get; set; }

        public virtual Treempaque NCodigoReempaqueNavigation { get; set; } = null!;
        public virtual Twarehouse NCodigoWarehouseNavigation { get; set; } = null!;
    }
}
