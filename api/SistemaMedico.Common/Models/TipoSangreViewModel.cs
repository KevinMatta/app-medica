using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class TipoSangreViewModel
    {
        public int TiSa_Id { get; set; }
        public string TiSa_Descripcion { get; set; }
        public bool? TiSa_Estado { get; set; }
        public int TiSa_Creacion { get; set; }
        public DateTime TiSa_FechaCreacion { get; set; }
        public int? TiSa_Modificacion { get; set; }
        public DateTime? TiSa_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
