using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebAdminPortal.Models;

namespace WebAdminPortal.DBContext
{
    public partial class PRE_ALTIUS_00_INTERMEDIAContext : DbContext
    {
        public PRE_ALTIUS_00_INTERMEDIAContext()
        {
        }

        public PRE_ALTIUS_00_INTERMEDIAContext(DbContextOptions<PRE_ALTIUS_00_INTERMEDIAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DatosParaProcesar> DatosParaProcesars { get; set; } = null!;
        public virtual DbSet<DistinctOpContainerNav> DistinctOpContainerNavs { get; set; } = null!;
        public virtual DbSet<OperacionesAProcesar> OperacionesAProcesars { get; set; } = null!;
        public virtual DbSet<RnkMovOpe> RnkMovOpes { get; set; } = null!;
        public virtual DbSet<_00Operacione> _00Operaciones { get; set; } = null!;
        public virtual DbSet<_00OperacionesMovimientosAut> _00OperacionesMovimientosAuts { get; set; } = null!;
        public virtual DbSet<_80UsuarioInforme> _80UsuarioInformes { get; set; } = null!;
        public virtual DbSet<_80UsuarioMailInforme> _80UsuarioMailInformes { get; set; } = null!;
        public virtual DbSet<_90InformesParametro> _90InformesParametros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PORTNABIHAGGLE\\SQLEXPRESS;Database=PRE_ALTIUS_00_INTERMEDIA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatosParaProcesar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Datos_Para_Procesar");

                entity.Property(e => e.CodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Matricula_Contenedor");

                entity.Property(e => e.DiffAct).HasColumnName("Diff_ACT");

                entity.Property(e => e.Evento).HasMaxLength(50);

                entity.Property(e => e.FechaActual)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actual");

                entity.Property(e => e.FechaActualTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_actual_time");

                entity.Property(e => e.FechaActualizaciónRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualización_Registro");

                entity.Property(e => e.FechaExpec)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Expec");

                entity.Property(e => e.FechaExpectedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_expected_time");

                entity.Property(e => e.FectAct)
                    .HasColumnType("datetime")
                    .HasColumnName("Fect_act");

                entity.Property(e => e.Navieras).HasMaxLength(50);

                entity.Property(e => e.NumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("Numero_Operacion");

                entity.Property(e => e.TipoEvento)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Evento");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DistinctOpContainerNav>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Distinct_OP_Container_Nav");

                entity.Property(e => e.CodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Matricula_Contenedor");

                entity.Property(e => e.Navieras).HasMaxLength(50);

                entity.Property(e => e.NumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("Numero_Operacion");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OperacionesAProcesar>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Operaciones_a_Procesar");

                entity.Property(e => e.CodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Matricula_Contenedor");

                entity.Property(e => e.Flujo).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Navieras).HasMaxLength(50);

                entity.Property(e => e.NumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("Numero_Operacion");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<RnkMovOpe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RNK_MOV_OPE");

                entity.Property(e => e.DidCodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("DID_Cod_Matricula_Contenedor");

                entity.Property(e => e.DidNumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("DID_Numero_Operacion");

                entity.Property(e => e.FechaActualTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_actual_time");

                entity.Property(e => e.FechaActualizaciónRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualización_Registro");

                entity.Property(e => e.FechaExpectedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_expected_time");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rnk).HasColumnName("rnk");

                entity.Property(e => e.TipoEvento)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Evento");
            });

            modelBuilder.Entity<_00Operacione>(entity =>
            {
                entity.ToTable("00_Operaciones");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("Cod_Matricula_Contenedor");

                entity.Property(e => e.Flujo).HasMaxLength(50);

                entity.Property(e => e.Navieras).HasMaxLength(50);

                entity.Property(e => e.NumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("Numero_Operacion");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<_00OperacionesMovimientosAut>(entity =>
            {
                entity.ToTable("00_Operaciones_Movimientos_Aut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DidCodMatriculaContenedor)
                    .HasMaxLength(50)
                    .HasColumnName("DID_Cod_Matricula_Contenedor");

                entity.Property(e => e.DidNumeroOperacion)
                    .HasMaxLength(50)
                    .HasColumnName("DID_Numero_Operacion");

                entity.Property(e => e.FechaActualTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_actual_time");

                entity.Property(e => e.FechaActualizaciónRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Actualización_Registro");

                entity.Property(e => e.FechaExpectedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_expected_time");

                entity.Property(e => e.TipoEvento)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_Evento");
            });

            modelBuilder.Entity<_80UsuarioInforme>(entity =>
            {
                entity.ToTable("80_Usuario_informe");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdInforme).HasColumnName("id_informe");

                entity.Property(e => e.UsuarioRelacion)
                    .HasMaxLength(10)
                    .HasColumnName("Usuario_Relacion")
                    .IsFixedLength();

                entity.HasOne(d => d.IdInformeNavigation)
                    .WithMany(p => p._80UsuarioInformes)
                    .HasForeignKey(d => d.IdInforme)
                    .HasConstraintName("FK_80_Usuario_informe_90_Informes_Parametros");
            });

            modelBuilder.Entity<_80UsuarioMailInforme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("80_Usuario_Mail_Informe");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IdInforme).HasColumnName("id_informe");

                entity.Property(e => e.NombreInforme)
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_informe");

                entity.Property(e => e.UsuarioRelacion)
                    .HasMaxLength(10)
                    .HasColumnName("Usuario_Relacion")
                    .IsFixedLength();
            });

            modelBuilder.Entity<_90InformesParametro>(entity =>
            {
                entity.HasKey(e => e.IdInforme);

                entity.ToTable("90_Informes_Parametros");

                entity.Property(e => e.IdInforme).HasColumnName("id_informe");

                entity.Property(e => e.NombreInforme)
                    .HasMaxLength(50)
                    .HasColumnName("Nombre_informe");

                entity.Property(e => e.Observaciones).HasMaxLength(500);

                entity.Property(e => e.TipoInforme)
                    .HasMaxLength(50)
                    .HasColumnName("Tipo_informe");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
