using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Treempaque
    {
        public Treempaque()
        {
            TreempaqueDetalles = new HashSet<TreempaqueDetalle>();
            TreempaqueWarehouses = new HashSet<TreempaqueWarehouse>();
        }

        public decimal NCodigoReempaque { get; set; }
        public decimal? NCodigoOrigen { get; set; }
        public decimal? NCodigoDestino { get; set; }
        public decimal? NCodigoShipper { get; set; }
        public decimal? NCodigoConsignee { get; set; }
        public decimal? NCodigoPosicion { get; set; }
        public int? NCantidadCajas { get; set; }
        public double? FPeso { get; set; }
        public string? CPa { get; set; }
        public string? CMedidas { get; set; }
        public double? FPesoActual { get; set; }
        public double? FPesoVolumen { get; set; }
        public double? FPesoCobrable { get; set; }
        public DateTime? DFechaCreacion { get; set; }
        public int? NCreadoPor { get; set; }
        public DateTime? DFechaModificacion { get; set; }
        public int? NModificadoPor { get; set; }
        public double? FCbm { get; set; }
        public int? NCodigoTransporte { get; set; }
        public string? CMc { get; set; }
        public string? CFolio { get; set; }
        public string? CEntregadoPor { get; set; }

        public virtual Tpersona? NCodigoConsigneeNavigation { get; set; }
        public virtual Tpuerto? NCodigoDestinoNavigation { get; set; }
        public virtual Tposicion? NCodigoPosicionNavigation { get; set; }
        public virtual ICollection<TreempaqueDetalle> TreempaqueDetalles { get; set; }
        public virtual ICollection<TreempaqueWarehouse> TreempaqueWarehouses { get; set; }
    }
}
