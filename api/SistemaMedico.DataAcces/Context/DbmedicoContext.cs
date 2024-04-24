﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaMedico.Entities.Entities;

#nullable disable

namespace SistemaMedico.DataAcces.Context
{
    public partial class DbmedicoContext : DbContext
    {
        public DbmedicoContext()
        {
        }

        public DbmedicoContext(DbContextOptions<DbmedicoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<tbAlimentos> tbAlimentos { get; set; }
        public virtual DbSet<tbCiudades> tbCiudades { get; set; }
        public virtual DbSet<tbDiagnosticos> tbDiagnosticos { get; set; }
        public virtual DbSet<tbDietas> tbDietas { get; set; }
        public virtual DbSet<tbEjercios> tbEjercios { get; set; }
        public virtual DbSet<tbEnfermedades> tbEnfermedades { get; set; }
        public virtual DbSet<tbEnfermedadesPorPersona> tbEnfermedadesPorPersona { get; set; }
        public virtual DbSet<tbEntrenamientos> tbEntrenamientos { get; set; }
        public virtual DbSet<tbEstados> tbEstados { get; set; }
        public virtual DbSet<tbEstadosCiviles> tbEstadosCiviles { get; set; }
        public virtual DbSet<tbEstadosSalud> tbEstadosSalud { get; set; }
        public virtual DbSet<tbPantallas> tbPantallas { get; set; }
        public virtual DbSet<tbPantallasPorRoles> tbPantallasPorRoles { get; set; }
        public virtual DbSet<tbPersonas> tbPersonas { get; set; }
        public virtual DbSet<tbRoles> tbRoles { get; set; }
        public virtual DbSet<tbTiposSangre> tbTiposSangre { get; set; }
        public virtual DbSet<tbUsuarios> tbUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<tbAlimentos>(entity =>
            {
                entity.HasKey(e => e.Alim_Id)
                    .HasName("PK__tbAlimen__021988348277A018");

                entity.ToTable("tbAlimentos", "Medi");

                entity.Property(e => e.Alim_Calorias).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Alim_Carbohidratos).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Alim_Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Alim_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Alim_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Alim_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Alim_Proteinas).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Alim_TipoComida)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Alim_CreacionNavigation)
                    .WithMany(p => p.tbAlimentosAlim_CreacionNavigation)
                    .HasForeignKey(d => d.Alim_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbAliment__Alim___76969D2E");

                entity.HasOne(d => d.Alim_ModificacionNavigation)
                    .WithMany(p => p.tbAlimentosAlim_ModificacionNavigation)
                    .HasForeignKey(d => d.Alim_Modificacion)
                    .HasConstraintName("FK__tbAliment__Alim___778AC167");
            });

            modelBuilder.Entity<tbCiudades>(entity =>
            {
                entity.HasKey(e => e.Ciud_Id)
                    .HasName("PK__tbCiudad__D0453088C3E9951A");

                entity.ToTable("tbCiudades", "Gene");

                entity.Property(e => e.Ciud_Id)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Ciud_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ciud_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ciud_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Ciud_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Esta_Id)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciud_CreacionNavigation)
                    .WithMany(p => p.tbCiudadesCiud_CreacionNavigation)
                    .HasForeignKey(d => d.Ciud_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbCiudade__Ciud___6B24EA82");

                entity.HasOne(d => d.Ciud_ModificacionNavigation)
                    .WithMany(p => p.tbCiudadesCiud_ModificacionNavigation)
                    .HasForeignKey(d => d.Ciud_Modificacion)
                    .HasConstraintName("FK__tbCiudade__Ciud___6C190EBB");

                entity.HasOne(d => d.Esta)
                    .WithMany(p => p.tbCiudades)
                    .HasForeignKey(d => d.Esta_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbCiudade__Esta___534D60F1");
            });

            modelBuilder.Entity<tbDiagnosticos>(entity =>
            {
                entity.HasKey(e => e.Diag_Id)
                    .HasName("PK__tbDiagno__1DA760ECB1E2AF0E");

                entity.ToTable("tbDiagnosticos", "Medi");

                entity.Property(e => e.Diag_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Diag_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Diag_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Diag_Peso).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Pers_Identidad)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.Diag_CreacionNavigation)
                    .WithMany(p => p.tbDiagnosticosDiag_CreacionNavigation)
                    .HasForeignKey(d => d.Diag_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbDiagnos__Diag___7A672E12");

                entity.HasOne(d => d.Diag_ModificacionNavigation)
                    .WithMany(p => p.tbDiagnosticosDiag_ModificacionNavigation)
                    .HasForeignKey(d => d.Diag_Modificacion)
                    .HasConstraintName("FK__tbDiagnos__Diag___7B5B524B");

                entity.HasOne(d => d.EsSa)
                    .WithMany(p => p.tbDiagnosticos)
                    .HasForeignKey(d => d.EsSa_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbDiagnos__EsSa___571DF1D5");
            });

            modelBuilder.Entity<tbDietas>(entity =>
            {
                entity.HasKey(e => e.Diet_Id)
                    .HasName("PK__tbDietas__0427878AB6360950");

                entity.ToTable("tbDietas", "Medi");

                entity.Property(e => e.Diet_Detalle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Diet_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Diet_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Diet_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Alim)
                    .WithMany(p => p.tbDietas)
                    .HasForeignKey(d => d.Alim_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbDietas__Alim_I__59FA5E80");

                entity.HasOne(d => d.Diag)
                    .WithMany(p => p.tbDietas)
                    .HasForeignKey(d => d.Diag_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbDietas__Diag_I__5AEE82B9");

                entity.HasOne(d => d.Diet_CreacionNavigation)
                    .WithMany(p => p.tbDietasDiet_CreacionNavigation)
                    .HasForeignKey(d => d.Diet_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbDietas__Diet_C__7E37BEF6");

                entity.HasOne(d => d.Diet_ModificacionNavigation)
                    .WithMany(p => p.tbDietasDiet_ModificacionNavigation)
                    .HasForeignKey(d => d.Diet_Modificacion)
                    .HasConstraintName("FK__tbDietas__Diet_M__7F2BE32F");
            });

            modelBuilder.Entity<tbEjercios>(entity =>
            {
                entity.HasKey(e => e.Ejer_Id)
                    .HasName("PK__tbEjerci__06163F043CCE68B9");

                entity.ToTable("tbEjercios", "Medi");

                entity.Property(e => e.Ejer_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ejer_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ejer_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Ejer_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Ejer_TipoEjercicio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ejer_CreacionNavigation)
                    .WithMany(p => p.tbEjerciosEjer_CreacionNavigation)
                    .HasForeignKey(d => d.Ejer_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEjercio__Ejer___7C4F7684");

                entity.HasOne(d => d.Ejer_ModificacionNavigation)
                    .WithMany(p => p.tbEjerciosEjer_ModificacionNavigation)
                    .HasForeignKey(d => d.Ejer_Modificacion)
                    .HasConstraintName("FK__tbEjercio__Ejer___7D439ABD");
            });

            modelBuilder.Entity<tbEnfermedades>(entity =>
            {
                entity.HasKey(e => e.Enfe_Id)
                    .HasName("PK__tbEnferm__9BCD0808E2CAD8C1");

                entity.ToTable("tbEnfermedades", "Medi");

                entity.Property(e => e.Enfe_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enfe_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Enfe_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Enfe_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Enfe_CreacionNavigation)
                    .WithMany(p => p.tbEnfermedadesEnfe_CreacionNavigation)
                    .HasForeignKey(d => d.Enfe_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEnferme__Enfe___72C60C4A");

                entity.HasOne(d => d.Enfe_ModificacionNavigation)
                    .WithMany(p => p.tbEnfermedadesEnfe_ModificacionNavigation)
                    .HasForeignKey(d => d.Enfe_Modificacion)
                    .HasConstraintName("FK__tbEnferme__Enfe___73BA3083");
            });

            modelBuilder.Entity<tbEnfermedadesPorPersona>(entity =>
            {
                entity.HasKey(e => e.EnPe_Id)
                    .HasName("PK__tbEnferm__109E9536DC98C851");

                entity.ToTable("tbEnfermedadesPorPersona", "Medi");

                entity.Property(e => e.EnPe_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.EnPe_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.EnPe_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Pers_Identidad)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.HasOne(d => d.EnPe_CreacionNavigation)
                    .WithMany(p => p.tbEnfermedadesPorPersonaEnPe_CreacionNavigation)
                    .HasForeignKey(d => d.EnPe_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEnferme__EnPe___787EE5A0");

                entity.HasOne(d => d.EnPe_ModificacionNavigation)
                    .WithMany(p => p.tbEnfermedadesPorPersonaEnPe_ModificacionNavigation)
                    .HasForeignKey(d => d.EnPe_Modificacion)
                    .HasConstraintName("FK__tbEnferme__EnPe___797309D9");

                entity.HasOne(d => d.Enfe)
                    .WithMany(p => p.tbEnfermedadesPorPersona)
                    .HasForeignKey(d => d.Enfe_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEnferme__Enfe___5812160E");

                entity.HasOne(d => d.Pers_IdentidadNavigation)
                    .WithMany(p => p.tbEnfermedadesPorPersona)
                    .HasForeignKey(d => d.Pers_Identidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEnferme__Pers___59063A47");
            });

            modelBuilder.Entity<tbEntrenamientos>(entity =>
            {
                entity.HasKey(e => e.Entr_Id)
                    .HasName("PK__tbEntren__F2ADE054CB184F74");

                entity.ToTable("tbEntrenamientos", "Medi");

                entity.Property(e => e.Entr_Detalle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entr_Duracion).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Entr_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Entr_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Entr_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Entr_Peso).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Diag)
                    .WithMany(p => p.tbEntrenamientos)
                    .HasForeignKey(d => d.Diag_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEntrena__Diag___5CD6CB2B");

                entity.HasOne(d => d.Ejer)
                    .WithMany(p => p.tbEntrenamientos)
                    .HasForeignKey(d => d.Ejer_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEntrena__Ejer___5BE2A6F2");

                entity.HasOne(d => d.Entr_CreacionNavigation)
                    .WithMany(p => p.tbEntrenamientosEntr_CreacionNavigation)
                    .HasForeignKey(d => d.Entr_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEntrena__Entr___00200768");

                entity.HasOne(d => d.Entr_ModificacionNavigation)
                    .WithMany(p => p.tbEntrenamientosEntr_ModificacionNavigation)
                    .HasForeignKey(d => d.Entr_Modificacion)
                    .HasConstraintName("FK__tbEntrena__Entr___01142BA1");
            });

            modelBuilder.Entity<tbEstados>(entity =>
            {
                entity.HasKey(e => e.Esta_Id)
                    .HasName("PK__tbEstado__D52AE7B830223BC9");

                entity.ToTable("tbEstados", "Gene");

                entity.Property(e => e.Esta_Id)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Esta_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esta_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Esta_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Esta_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Esta_CreacionNavigation)
                    .WithMany(p => p.tbEstadosEsta_CreacionNavigation)
                    .HasForeignKey(d => d.Esta_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEstados__Esta___693CA210");

                entity.HasOne(d => d.Esta_ModificacionNavigation)
                    .WithMany(p => p.tbEstadosEsta_ModificacionNavigation)
                    .HasForeignKey(d => d.Esta_Modificacion)
                    .HasConstraintName("FK__tbEstados__Esta___6A30C649");
            });

            modelBuilder.Entity<tbEstadosCiviles>(entity =>
            {
                entity.HasKey(e => e.EsCi_Id)
                    .HasName("PK__tbEstado__6D7205749C62AE2F");

                entity.ToTable("tbEstadosCiviles", "Gene");

                entity.Property(e => e.EsCi_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EsCi_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.EsCi_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.EsCi_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.EsCi_CreacionNavigation)
                    .WithMany(p => p.tbEstadosCivilesEsCi_CreacionNavigation)
                    .HasForeignKey(d => d.EsCi_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEstados__EsCi___6D0D32F4");

                entity.HasOne(d => d.EsCi_ModificacionNavigation)
                    .WithMany(p => p.tbEstadosCivilesEsCi_ModificacionNavigation)
                    .HasForeignKey(d => d.EsCi_Modificacion)
                    .HasConstraintName("FK__tbEstados__EsCi___6E01572D");
            });

            modelBuilder.Entity<tbEstadosSalud>(entity =>
            {
                entity.HasKey(e => e.EsSa_Id)
                    .HasName("PK__tbEstado__EA0B631994D7A6EE");

                entity.ToTable("tbEstadosSalud", "Medi");

                entity.Property(e => e.EsSa_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EsSa_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.EsSa_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.EsSa_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.EsSa_CreacionNavigation)
                    .WithMany(p => p.tbEstadosSaludEsSa_CreacionNavigation)
                    .HasForeignKey(d => d.EsSa_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbEstados__EsSa___74AE54BC");

                entity.HasOne(d => d.EsSa_ModificacionNavigation)
                    .WithMany(p => p.tbEstadosSaludEsSa_ModificacionNavigation)
                    .HasForeignKey(d => d.EsSa_Modificacion)
                    .HasConstraintName("FK__tbEstados__EsSa___75A278F5");
            });

            modelBuilder.Entity<tbPantallas>(entity =>
            {
                entity.HasKey(e => e.Pant_Id)
                    .HasName("PK__tbPantal__CF98C9322579A404");

                entity.ToTable("tbPantallas", "Acce");

                entity.Property(e => e.Pant_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pant_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pant_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Pant_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Pant_CreacionNavigation)
                    .WithMany(p => p.tbPantallasPant_CreacionNavigation)
                    .HasForeignKey(d => d.Pant_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPantall__Pant___656C112C");

                entity.HasOne(d => d.Pant_ModificacionNavigation)
                    .WithMany(p => p.tbPantallasPant_ModificacionNavigation)
                    .HasForeignKey(d => d.Pant_Modificacion)
                    .HasConstraintName("FK__tbPantall__Pant___66603565");
            });

            modelBuilder.Entity<tbPantallasPorRoles>(entity =>
            {
                entity.HasKey(e => e.PaRo_Id)
                    .HasName("PK__tbPantal__2288465732168B56");

                entity.ToTable("tbPantallasPorRoles", "Acce");

                entity.Property(e => e.PaRo_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaRo_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.PaRo_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.PaRo_CreacionNavigation)
                    .WithMany(p => p.tbPantallasPorRolesPaRo_CreacionNavigation)
                    .HasForeignKey(d => d.PaRo_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPantall__PaRo___6754599E");

                entity.HasOne(d => d.PaRo_ModificacionNavigation)
                    .WithMany(p => p.tbPantallasPorRolesPaRo_ModificacionNavigation)
                    .HasForeignKey(d => d.PaRo_Modificacion)
                    .HasConstraintName("FK__tbPantall__PaRo___68487DD7");

                entity.HasOne(d => d.Pant)
                    .WithMany(p => p.tbPantallasPorRoles)
                    .HasForeignKey(d => d.Pant_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPantall__Pant___5FB337D6");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.tbPantallasPorRoles)
                    .HasForeignKey(d => d.Rol_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPantall__Rol_I__60A75C0F");
            });

            modelBuilder.Entity<tbPersonas>(entity =>
            {
                entity.HasKey(e => e.Pers_Identidad)
                    .HasName("PK__tbPerson__AD277398153F752F");

                entity.ToTable("tbPersonas", "Gene");

                entity.Property(e => e.Pers_Identidad)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Ciud_Id)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Pers_Altura).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Pers_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Pers_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Pers_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Pers_Nacimiento).HasColumnType("datetime");

                entity.Property(e => e.Pers_PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pers_PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pers_SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pers_SegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pers_Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Ciud)
                    .WithMany(p => p.tbPersonas)
                    .HasForeignKey(d => d.Ciud_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPersona__Ciud___5535A963");

                entity.HasOne(d => d.EsCi)
                    .WithMany(p => p.tbPersonas)
                    .HasForeignKey(d => d.EsCi_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPersona__EsCi___5441852A");

                entity.HasOne(d => d.Pers_CreacionNavigation)
                    .WithMany(p => p.tbPersonasPers_CreacionNavigation)
                    .HasForeignKey(d => d.Pers_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPersona__Pers___6EF57B66");

                entity.HasOne(d => d.Pers_ModificacionNavigation)
                    .WithMany(p => p.tbPersonasPers_ModificacionNavigation)
                    .HasForeignKey(d => d.Pers_Modificacion)
                    .HasConstraintName("FK__tbPersona__Pers___6FE99F9F");

                entity.HasOne(d => d.TiSa)
                    .WithMany(p => p.tbPersonas)
                    .HasForeignKey(d => d.TiSa_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbPersona__TiSa___5629CD9C");

                entity.HasOne(d => d.Usua)
                    .WithMany(p => p.tbPersonasUsua)
                    .HasForeignKey(d => d.Usua_Id)
                    .HasConstraintName("FK__tbPersona__Usua___5DCAEF64");
            });

            modelBuilder.Entity<tbRoles>(entity =>
            {
                entity.HasKey(e => e.Rol_Id)
                    .HasName("PK__tbRoles__795EBD49A20CC928");

                entity.ToTable("tbRoles", "Acce");

                entity.Property(e => e.Rol_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rol_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Rol_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Rol_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.Rol_CreacionNavigation)
                    .WithMany(p => p.tbRolesRol_CreacionNavigation)
                    .HasForeignKey(d => d.Rol_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbRoles__Rol_Cre__6383C8BA");

                entity.HasOne(d => d.Rol_ModificacionNavigation)
                    .WithMany(p => p.tbRolesRol_ModificacionNavigation)
                    .HasForeignKey(d => d.Rol_Modificacion)
                    .HasConstraintName("FK__tbRoles__Rol_Mod__6477ECF3");
            });

            modelBuilder.Entity<tbTiposSangre>(entity =>
            {
                entity.HasKey(e => e.TiSa_Id)
                    .HasName("PK__tbTiposS__93A6D3CE677B3084");

                entity.ToTable("tbTiposSangre", "Medi");

                entity.Property(e => e.TiSa_Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiSa_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.TiSa_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.TiSa_FechaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.TiSa_CreacionNavigation)
                    .WithMany(p => p.tbTiposSangreTiSa_CreacionNavigation)
                    .HasForeignKey(d => d.TiSa_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbTiposSa__TiSa___70DDC3D8");

                entity.HasOne(d => d.TiSa_ModificacionNavigation)
                    .WithMany(p => p.tbTiposSangreTiSa_ModificacionNavigation)
                    .HasForeignKey(d => d.TiSa_Modificacion)
                    .HasConstraintName("FK__tbTiposSa__TiSa___71D1E811");
            });

            modelBuilder.Entity<tbUsuarios>(entity =>
            {
                entity.HasKey(e => e.Usua_Id)
                    .HasName("PK__tbUsuari__E863C8EE9FE963BD");

                entity.ToTable("tbUsuarios", "Acce");

                entity.Property(e => e.Usua_Clave).IsRequired();

                entity.Property(e => e.Usua_Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Usua_FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Usua_FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.Usua_Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.tbUsuarios)
                    .HasForeignKey(d => d.Rol_Id)
                    .HasConstraintName("FK__tbUsuario__Rol_I__5EBF139D");

                entity.HasOne(d => d.Usua_CreacionNavigation)
                    .WithMany(p => p.InverseUsua_CreacionNavigation)
                    .HasForeignKey(d => d.Usua_Creacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbUsuario__Usua___619B8048");

                entity.HasOne(d => d.Usua_ModificacionNavigation)
                    .WithMany(p => p.InverseUsua_ModificacionNavigation)
                    .HasForeignKey(d => d.Usua_Modificacion)
                    .HasConstraintName("FK__tbUsuario__Usua___628FA481");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}