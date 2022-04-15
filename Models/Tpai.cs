using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tpai
    {
        public Tpai()
        {
            Tpersonas = new HashSet<Tpersona>();
        }

        public decimal NCodigoPais { get; set; }
        public string? CPais { get; set; }

        public virtual ICollection<Tpersona> Tpersonas { get; set; }
    }
}
