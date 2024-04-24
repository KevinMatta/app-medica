using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class EnfermedadesViewModel
    {
        public int Enfe_Id { get; set; }
        public string Enfe_Descripcion { get; set; }
        public bool? Enfe_Estado { get; set; }
        public int Enfe_Creacion { get; set; }
        public DateTime Enfe_FechaCreacion { get; set; }
        public int? Enfe_Modificacion { get; set; }
        public DateTime? Enfe_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
