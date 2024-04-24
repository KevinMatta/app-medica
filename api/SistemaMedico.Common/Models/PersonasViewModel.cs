using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class PersonasViewModel
    {
        public string Pers_Identidad { get; set; }
        public string Pers_PrimerNombre { get; set; }
        public string Pers_SegundoNombre { get; set; }
        public string Pers_PrimerApellido { get; set; }
        public string Pers_SegundoApellido { get; set; }
        public string Pers_Sexo { get; set; }
        public decimal Pers_Altura { get; set; }
        public DateTime? Pers_Nacimiento { get; set; }
        public int TiSa_Id { get; set; }
        public int? Usua_Id { get; set; }
        public int EsCi_Id { get; set; }
        public string Ciud_Id { get; set; }
        public bool? Pers_Estado { get; set; }
        public int Pers_Creacion { get; set; }
        public DateTime Pers_FechaCreacion { get; set; }
        public int? Pers_Modificacion { get; set; }
        public DateTime? Pers_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
