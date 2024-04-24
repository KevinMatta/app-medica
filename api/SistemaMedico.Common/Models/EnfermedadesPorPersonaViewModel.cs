using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class EnfermedadesPorPersonaViewModel
    {
        public int EnPe_Id { get; set; }
        public int Enfe_Id { get; set; }
        public string Pers_Identidad { get; set; }
        public bool? EnPe_Estado { get; set; }
        public int EnPe_Creacion { get; set; }
        public DateTime EnPe_FechaCreacion { get; set; }
        public int? EnPe_Modificacion { get; set; }
        public DateTime? EnPe_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
