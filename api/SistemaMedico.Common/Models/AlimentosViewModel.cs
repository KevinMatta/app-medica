using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class AlimentosViewModel
    {
        public int Alim_Id { get; set; }
        public string Alim_Descripcion { get; set; }
        public string Alim_TipoComida { get; set; }
        public decimal? Alim_Calorias { get; set; }
        public decimal? Alim_Proteinas { get; set; }
        public decimal? Alim_Carbohidratos { get; set; }
        public bool? Alim_Estado { get; set; }
        public int Alim_Creacion { get; set; }
        public DateTime Alim_FechaCreacion { get; set; }
        public int? Alim_Modificacion { get; set; }
        public DateTime? Alim_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
