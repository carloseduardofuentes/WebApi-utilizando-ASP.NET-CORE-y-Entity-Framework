using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tpuerto
    {
        public Tpuerto()
        {
            TbillOfLadingNCodigoDestinoNavigations = new HashSet<TbillOfLading>();
            TbillOfLadingNCodigoOrigenNavigations = new HashSet<TbillOfLading>();
            Tpersonas = new HashSet<Tpersona>();
            Treempaques = new HashSet<Treempaque>();
            TwarehouseNCodigoDestinoNavigations = new HashSet<Twarehouse>();
            TwarehouseNCodigoOrigenNavigations = new HashSet<Twarehouse>();
        }

        public decimal NCodigoPuerto { get; set; }
        public decimal? NCodigoPais { get; set; }
        public string? CPuerto { get; set; }

        public virtual ICollection<TbillOfLading> TbillOfLadingNCodigoDestinoNavigations { get; set; }
        public virtual ICollection<TbillOfLading> TbillOfLadingNCodigoOrigenNavigations { get; set; }
        public virtual ICollection<Tpersona> Tpersonas { get; set; }
        public virtual ICollection<Treempaque> Treempaques { get; set; }
        public virtual ICollection<Twarehouse> TwarehouseNCodigoDestinoNavigations { get; set; }
        public virtual ICollection<Twarehouse> TwarehouseNCodigoOrigenNavigations { get; set; }
    }
}
