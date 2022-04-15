using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tcarrier
    {
        public Tcarrier()
        {
            Twarehouses = new HashSet<Twarehouse>();
        }

        public decimal NCodigoCarrier { get; set; }
        public string CCarrier { get; set; } = null!;

        public virtual ICollection<Twarehouse> Twarehouses { get; set; }
    }
}
