﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaMedico.Entities.Entities
{
    public partial class tbEjercios
    {
        public tbEjercios()
        {
            tbEntrenamientos = new HashSet<tbEntrenamientos>();
        }

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
        public virtual tbUsuarios Ejer_CreacionNavigation { get; set; }
        public virtual tbUsuarios Ejer_ModificacionNavigation { get; set; }
        public virtual ICollection<tbEntrenamientos> tbEntrenamientos { get; set; }
    }
}