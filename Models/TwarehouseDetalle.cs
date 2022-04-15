using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class TwarehouseDetalle
    {
        public decimal NCodigoWarehouse { get; set; }
        public int NCodigoWarehouseDetalle { get; set; }
        public int? NCantidadCajas { get; set; }
        public int? NLargo { get; set; }
        public int? NAncho { get; set; }
        public int? NAlto { get; set; }

        public virtual Twarehouse NCodigoWarehouseNavigation { get; set; } = null!;
    }
}
