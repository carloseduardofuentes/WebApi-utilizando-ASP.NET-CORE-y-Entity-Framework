using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class ThistorialWarehouse
    {
        public decimal NCodigoWarehouse { get; set; }
        public decimal? NCodigoOrigen { get; set; }
        public decimal? NCodigoDestino { get; set; }
        public decimal? NCodigoShipper { get; set; }
        public decimal? NCodigoConsignee { get; set; }
        public decimal? NCodigoPosicion { get; set; }
        public decimal? NCodigoModo { get; set; }
        public decimal? NCodigoCarrier { get; set; }
        public string CWa { get; set; } = null!;
        public bool? BPaqueteria { get; set; }
        public string? CTracking { get; set; }
        public int? NCantidadCajas { get; set; }
        public double? FPeso { get; set; }
        public string? CMedidas { get; set; }
        public string? CRecibidaPor { get; set; }
        public DateTime? DFechaRecibida { get; set; }
        public string? CDescripcion { get; set; }
        public string? CComentarios { get; set; }
        public bool? BCorreoEnviado { get; set; }
        public int? NCodigoEstado { get; set; }
        public DateTime? DFechaCreacion { get; set; }
        public int? NCreadoPor { get; set; }
        public DateTime? DFechaModificacion { get; set; }
        public int? NModificadoPor { get; set; }
        public DateTime? DFechaAccion { get; set; }
        public string? CMaquinaAccion { get; set; }
        public string? CAplicacionAccion { get; set; }
        public string? CAccion { get; set; }
    }
}
