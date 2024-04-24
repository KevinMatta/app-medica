using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class EntrenamientosViewModel
    {
        public int Entr_Id { get; set; }
        public int Diag_Id { get; set; }
        public int Ejer_Id { get; set; }
        public decimal? Entr_Peso { get; set; }
        public decimal? Entr_Duracion { get; set; }
        public int? Entr_Repeticiones { get; set; }
        public int? Entr_Sets { get; set; }
        public string Entr_Detalle { get; set; }
        public bool? Entr_Estado { get; set; }
        public int Entr_Creacion { get; set; }
        public DateTime Entr_FechaCreacion { get; set; }
        public int? Entr_Modificacion { get; set; }
        public DateTime? Entr_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
