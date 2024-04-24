using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class EstadosSaludViewModel
    {
        public int EsSa_Id { get; set; }
        public string EsSa_Descripcion { get; set; }
        public bool? EsSa_Estado { get; set; }
        public int EsSa_Creacion { get; set; }
        public DateTime EsSa_FechaCreacion { get; set; }
        public int? EsSa_Modificacion { get; set; }
        public DateTime? EsSa_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }

    }
}
