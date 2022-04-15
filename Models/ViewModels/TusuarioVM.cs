using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApi_CargoWeb.Models.ViewModels
{
    [Keyless]
    public class TusuarioVM
    {
        public decimal N_Codigo_Usuario { get; set; }
        public string? C_Nombre_Persona { get; set; }
        public string C_Nombre_Usuario { get; set; } = null!;
        public string? C_Password { get; set; }
        public DateTime? D_Fecha_Caducidad { get; set; }
        public DateTime? D_Fecha_Creado { get; set; }
        public string? C_Maquina_Creado { get; set; }
        public string? C_Aplicacion_Creado { get; set; }
        public DateTime? D_Fecha_Modificado { get; set; }
        public string? C_Maquina_Modificado { get; set; }
        public string? C_Aplicacion_Modificado { get; set; }
        public bool? B_Activo { get; set; }
        public decimal N_Codigo_Perfil { get; set; }
        public string C_Nombre_Perfil { get; set; } = null!;
        public string? C_Impresor_Recibo1 { get; set; }
        public string? C_Impresor_Recibo2 { get; set; }
        public string? C_IMpresor_Etiqueta { get; set; }
    }
}
