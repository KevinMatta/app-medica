﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaMedico.Entities.Entities
{
    public partial class tbAlimentos
    {
        public tbAlimentos()
        {
            tbDietas = new HashSet<tbDietas>();
        }

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
        public virtual tbUsuarios Alim_CreacionNavigation { get; set; }
        public virtual tbUsuarios Alim_ModificacionNavigation { get; set; }
        public virtual ICollection<tbDietas> tbDietas { get; set; }
    }
}