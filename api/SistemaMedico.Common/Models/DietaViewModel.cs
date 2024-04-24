using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.Common.Models
{
    public class DietaViewModel
    {
        public int Diet_Id { get; set; }
        public int Diag_Id { get; set; }
        public int Alim_Id { get; set; }
        public string Diet_Detalle { get; set; }
        public bool? Diet_Estado { get; set; }
        public int Diet_Creacion { get; set; }
        public DateTime Diet_FechaCreacion { get; set; }
        public int? Diet_Modificacion { get; set; }
        public DateTime? Diet_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
    }
}
