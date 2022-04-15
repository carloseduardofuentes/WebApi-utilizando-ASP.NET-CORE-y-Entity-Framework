using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tusuario
    {
        public Tusuario()
        {
            NCodigoPerfils = new HashSet<Tperfil>();
        }

        public decimal NCodigoUsuario { get; set; }
        public string? CNombrePersona { get; set; }
        public string CNombreUsuario { get; set; } = null!;
        public string? CPassword { get; set; }
        public DateTime? DFechaCaducidad { get; set; }
        public DateTime? DFechaCreado { get; set; }
        public string? CMaquinaCreado { get; set; }
        public string? CAplicacionCreado { get; set; }
        public DateTime? DFechaModificado { get; set; }
        public string? CMaquinaModificado { get; set; }
        public string? CAplicacionModificado { get; set; }
        public bool? BActivo { get; set; }
        public string? CImpresorRecibo1 { get; set; }
        public string? CImpresorRecibo2 { get; set; }
        public string? CIMpresorEtiqueta { get; set; }

        public virtual ICollection<Tperfil> NCodigoPerfils { get; set; }
    }
}
