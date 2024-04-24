using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class EstadosViewModel
    {
        public string Esta_Id { get; set; }
        public string Esta_Descripcion { get; set; }
        public bool? Esta_Estado { get; set; }
        public int Esta_Creacion { get; set; }
        public DateTime Esta_FechaCreacion { get; set; }
        public int? Esta_Modificacion { get; set; }
        public DateTime? Esta_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
