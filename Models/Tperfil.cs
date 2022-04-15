using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tperfil
    {
        public Tperfil()
        {
            NCodigoUsuarios = new HashSet<Tusuario>();
        }

        public decimal NCodigoPerfil { get; set; }
        public string CNombrePerfil { get; set; } = null!;

        public virtual ICollection<Tusuario> NCodigoUsuarios { get; set; }
    }
}
