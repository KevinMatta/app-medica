using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class EjercicioViewModel
    {
        public int Ejer_Id { get; set; }
        public string Ejer_Descripcion { get; set; }
        public string Ejer_TipoEjercicio { get; set; }
        public bool? Ejer_Estado { get; set; }
        public int Ejer_Creacion { get; set; }
        public DateTime Ejer_FechaCreacion { get; set; }
        public int? Ejer_Modificacion { get; set; }
        public DateTime? Ejer_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
