using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class RolesViewModel
    {
        public string Rol_Descripcion { get; set; }
        public bool? Rol_Estado { get; set; }
        public int Rol_Creacion { get; set; }
        public DateTime Rol_FechaCreacion { get; set; }
        public int? Rol_Modificacion { get; set; }
        public DateTime? Rol_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
