using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class TbillOfLading
    {
        public decimal NCodigoBill { get; set; }
        public decimal? NCodigoOrigen { get; set; }
        public decimal? NCodigoDestino { get; set; }
        public decimal? NCodigoShipper { get; set; }
        public decimal? NCodigoConsignee { get; set; }
        public decimal? NCodigoPosicion { get; set; }
        public string CBill { get; set; } = null!;
        public decimal? NCodigoCharged { get; set; }
        public decimal? MCodAmount { get; set; }
        public decimal? NTypeFunds { get; set; }
        public decimal? NServiceLevel { get; set; }
        public decimal? NCwt { get; set; }
        public decimal? NFreight { get; set; }
        public decimal? NPickup { get; set; }
        public decimal? NDelivery { get; set; }
        public decimal? NOther { get; set; }
        public decimal? NOther2 { get; set; }
        public decimal? NAdvanceOrigin { get; set; }
        public decimal? NAdvanceDestination { get; set; }
        public decimal? NPieces { get; set; }
        public decimal? NWeight { get; set; }
        public decimal? NWt { get; set; }
        public decimal? NCbm { get; set; }
        public string? CRecibidaPor { get; set; }
        public DateTime? DFechaRecibida { get; set; }
        public string? CComentarios { get; set; }
        public bool? BCorreoEnviado { get; set; }
        public int? NCodigoEstado { get; set; }
        public DateTime? DFechaCreacion { get; set; }
        public int? NCreadoPor { get; set; }
        public DateTime? DFechaModificacion { get; set; }
        public int? NModificadoPor { get; set; }

        public virtual Tpersona? NCodigoConsigneeNavigation { get; set; }
        public virtual Tpuerto? NCodigoDestinoNavigation { get; set; }
        public virtual Tpuerto? NCodigoOrigenNavigation { get; set; }
        public virtual Tpersona? NCodigoShipperNavigation { get; set; }
    }
}
