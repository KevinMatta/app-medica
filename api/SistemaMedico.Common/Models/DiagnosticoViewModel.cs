using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class DiagnosticoViewModel
    {
        public int Diag_Id { get; set; }
        public string Pers_Identidad { get; set; }
        public int EsSa_Id { get; set; }
        public decimal? Diag_Peso { get; set; }
        public bool? Diag_Estado { get; set; }
        public int Diag_Creacion { get; set; }
        public DateTime Diag_FechaCreacion { get; set; }
        public int? Diag_Modificacion { get; set; }
        public DateTime? Diag_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }

        [NotMapped]
        public string EsSa_Descripcion { get; set; }

        [NotMapped]
        public string Nombre { get; set; }
        [NotMapped]
        public string Pers_Altura { get; set; }

        [NotMapped]
        public int Edad { get; set; }

        [NotMapped]
        public int Alim_Id { get; set; }

        [NotMapped]
        public string Alim_Descripcion { get; set; }

        [NotMapped]
        public string Alim_TipoComida { get; set; }

        [NotMapped]
        public string Alim_Calorias { get; set; }

        [NotMapped]
        public string Alim_Proteinas { get; set; }

        [NotMapped]
        public string Alim_Carbohidratos { get; set; }

        [NotMapped]
        public int Entr_Id { get; set; }

        [NotMapped]
        public string Ejer_Descripcion { get; set; }

        [NotMapped]
        public string Ejer_Tipo { get; set; }

        [NotMapped]
        public double Entr_Peso { get; set; }

        [NotMapped]
        public double Entr_Duracion {get; set;}

        [NotMapped]
        public string Entr_Repeticiones {get; set;}

        [NotMapped]
        public int Entr_Sets { get; set; }

}
}
