using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tpersona
    {
        public Tpersona()
        {
            TbillOfLadingNCodigoConsigneeNavigations = new HashSet<TbillOfLading>();
            TbillOfLadingNCodigoShipperNavigations = new HashSet<TbillOfLading>();
            TposicionTpersonas = new HashSet<TposicionTpersona>();
            Treempaques = new HashSet<Treempaque>();
            TwarehouseNCodigoConsigneeNavigations = new HashSet<Twarehouse>();
            TwarehouseNCodigoShipperNavigations = new HashSet<Twarehouse>();
        }

        public decimal NCodigoPersona { get; set; }
        public string CNombres { get; set; } = null!;
        public decimal? NCodigoPais { get; set; }
        public decimal? NCodigoPuerto { get; set; }
        public decimal? NCodigoTipo { get; set; }
        public string? CMarca { get; set; }
        public string? CContacto { get; set; }
        public string? CEstado { get; set; }
        public string? CCiudad { get; set; }
        public string? CDireccion { get; set; }
        public string? CTelefono { get; set; }
        public string? CFax { get; set; }
        public string? CEmail { get; set; }
        public string? CDireccion2 { get; set; }
        public string? CTelefono2 { get; set; }
        public string? CFax2 { get; set; }
        public string? CEmail2 { get; set; }
        public string? CZip { get; set; }
        public DateTime? DFechaCreacion { get; set; }
        public int? NCreadoPor { get; set; }
        public DateTime? DFechaModificacion { get; set; }
        public int? NModificadoPor { get; set; }

        public virtual Tpai? NCodigoPaisNavigation { get; set; }
        public virtual Tpuerto? NCodigoPuertoNavigation { get; set; }
        public virtual TtipoPersona? NCodigoTipoNavigation { get; set; }
        public virtual ICollection<TbillOfLading> TbillOfLadingNCodigoConsigneeNavigations { get; set; }
        public virtual ICollection<TbillOfLading> TbillOfLadingNCodigoShipperNavigations { get; set; }
        public virtual ICollection<TposicionTpersona> TposicionTpersonas { get; set; }
        public virtual ICollection<Treempaque> Treempaques { get; set; }
        public virtual ICollection<Twarehouse> TwarehouseNCodigoConsigneeNavigations { get; set; }
        public virtual ICollection<Twarehouse> TwarehouseNCodigoShipperNavigations { get; set; }
    }
}
