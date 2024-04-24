using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class PantallasPorRolesViewModel
    {
        public int PaRo_Id { get; set; }
        public int Pant_Id { get; set; }
        public int Rol_Id { get; set; }
        public bool? PaRo_Estado { get; set; }
        public int PaRo_Creacion { get; set; }
        public DateTime PaRo_FechaCreacion { get; set; }
        public int? PaRo_Modificacion { get; set; }
        public DateTime? PaRo_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
