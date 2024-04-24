using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class UsuariosViewModel
    {
        public int Usua_Id { get; set; }
        public string Usua_Usuario { get; set; }
        public string Usua_Clave { get; set; }
        public bool? Usua_IsAdmin { get; set; }
        public int? Rol_Id { get; set; }
        public bool? Usua_Estado { get; set; }
        public int Usua_Creacion { get; set; }
        public DateTime Usua_FechaCreacion { get; set; }
        public int? Usua_Modificacion { get; set; }
        public DateTime? Usua_FechaModificacion { get; set; }
        public string Usua_CorreoElectronico { get; set; }
        public string Usua_CodigoV { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
        [NotMapped]
        public string Rol_Descripcion { get; set; }

        [NotMapped]
        public string Usua_Administrador { get; set; }
    }
}
