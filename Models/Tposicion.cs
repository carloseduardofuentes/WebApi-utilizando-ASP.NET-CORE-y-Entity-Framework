using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tposicion
    {
        public Tposicion()
        {
            TposicionTpersonas = new HashSet<TposicionTpersona>();
            Treempaques = new HashSet<Treempaque>();
            Twarehouses = new HashSet<Twarehouse>();
        }

        public decimal NCodigoPosicion { get; set; }
        public string CPosicion { get; set; } = null!;
        public bool BEstado { get; set; }

        public virtual ICollection<TposicionTpersona> TposicionTpersonas { get; set; }
        public virtual ICollection<Treempaque> Treempaques { get; set; }
        public virtual ICollection<Twarehouse> Twarehouses { get; set; }
    }
}
