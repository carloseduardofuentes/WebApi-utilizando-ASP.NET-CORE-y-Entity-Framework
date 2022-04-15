using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class TposicionTpersona
    {
        public decimal NCodigoPosicion { get; set; }
        public decimal NCodigoPersona { get; set; }
        public DateTime? DFechaCreacion { get; set; }
        public int? NCreadoPor { get; set; }
        public DateTime? DFechaModificacion { get; set; }
        public int? NModificadoPor { get; set; }

        public virtual Tpersona NCodigoPersonaNavigation { get; set; } = null!;
        public virtual Tposicion NCodigoPosicionNavigation { get; set; } = null!;
    }
}
