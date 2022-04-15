using System;
using System.Collections.Generic;

namespace WebApi_CargoWeb.Models
{
    public partial class Tpantalla
    {
        public int? NCantidadRegistros { get; set; }
        public int? NSegundos { get; set; }
        public string? CMensaje { get; set; }
        public string? CRutaVideo { get; set; }
        public string? CServidorSmtp { get; set; }
        public string? CPuertoSmtp { get; set; }
        public string? CCuentaEmail { get; set; }
        public string? CClaveEmail { get; set; }
        public string? CImpresorRecibo1 { get; set; }
        public string? CImpresorRecibo2 { get; set; }
        public string? CImpresorEtiqueta { get; set; }
    }
}
