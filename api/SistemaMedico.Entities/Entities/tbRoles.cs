﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace SistemaMedico.Entities.Entities
{
    public partial class tbRoles
    {
        public tbRoles()
        {
            tbPantallasPorRoles = new HashSet<tbPantallasPorRoles>();
            tbUsuarios = new HashSet<tbUsuarios>();
        }

        public int Rol_Id { get; set; }
        public string Rol_Descripcion { get; set; }
        public bool? Rol_Estado { get; set; }
        public int Rol_Creacion { get; set; }
        public DateTime Rol_FechaCreacion { get; set; }
        public int? Rol_Modificacion { get; set; }
        public DateTime? Rol_FechaModificacion { get; set; }
        [NotMapped]
        public string Creacion { get; set; }
        [NotMapped]
        public string Modificacion { get; set; }
        public virtual tbUsuarios Rol_CreacionNavigation { get; set; }
        public virtual tbUsuarios Rol_ModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
        public virtual ICollection<tbUsuarios> tbUsuarios { get; set; }
    }
}