using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tmodo
    {
        public Tmodo()
        {
            Twarehouses = new HashSet<Twarehouse>();
        }

        public decimal NCodigoModo { get; set; }
        public string CModo { get; set; } = null!;

        public virtual ICollection<Twarehouse> Twarehouses { get; set; }
    }
}
