using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class TtipoPersona
    {
        public TtipoPersona()
        {
            Tpersonas = new HashSet<Tpersona>();
        }

        public decimal NCodigoTipo { get; set; }
        public string? CTipo { get; set; }

        public virtual ICollection<Tpersona> Tpersonas { get; set; }
    }
}
