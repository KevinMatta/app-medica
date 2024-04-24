﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaMedico.Entities.Entities
{
    public partial class tbEstadosSalud
    {
        public tbEstadosSalud()
        {
            tbDiagnosticos = new HashSet<tbDiagnosticos>();
        }

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
        public virtual tbUsuarios EsSa_CreacionNavigation { get; set; }
        public virtual tbUsuarios EsSa_ModificacionNavigation { get; set; }
        public virtual ICollection<tbDiagnosticos> tbDiagnosticos { get; set; }
    }
}