﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAdminPortal.DBContext;

#nullable disable

namespace WebAdminPortal.Migrations
{
    [DbContext(typeof(PRE_ALTIUS_00_INTERMEDIAContext))]
    partial class PRE_ALTIUS_00_INTERMEDIAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WebAdminPortal.Models._00Operacione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodMatriculaContenedor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Cod_Matricula_Contenedor");

                    b.Property<string>("Flujo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Navieras")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Numero_Operacion");

                    b.Property<string>("Usuario")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("00_Operaciones", (string)null);
                });

            modelBuilder.Entity("WebAdminPortal.Models._00OperacionesMovimientosAut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DidCodMatriculaContenedor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DID_Cod_Matricula_Contenedor");

                    b.Property<string>("DidNumeroOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DID_Numero_Operacion");

                    b.Property<DateTime?>("FechaActualTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_actual_time");

                    b.Property<DateTime?>("FechaActualizaciónRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_Actualización_Registro");

                    b.Property<DateTime?>("FechaExpectedTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_expected_time");

                    b.Property<string>("TipoEvento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Tipo_Evento");

                    b.HasKey("Id");

                    b.ToTable("00_Operaciones_Movimientos_Aut", (string)null);
                });

            modelBuilder.Entity("WebAdminPortal.Models._80UsuarioInforme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Activo")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<int?>("IdInforme")
                        .HasColumnType("int")
                        .HasColumnName("id_informe");

                    b.Property<string>("UsuarioRelacion")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("Usuario_Relacion")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdInforme");

                    b.ToTable("80_Usuario_informe", (string)null);
                });

            modelBuilder.Entity("WebAdminPortal.Models._80UsuarioMailInforme", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<int>("IdInforme")
                        .HasColumnType("int")
                        .HasColumnName("id_informe");

                    b.Property<string>("NombreInforme")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre_informe");

                    b.Property<string>("UsuarioRelacion")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("Usuario_Relacion")
                        .IsFixedLength();

                    b.ToView("80_Usuario_Mail_Informe");
                });

            modelBuilder.Entity("WebAdminPortal.Models._90InformesParametro", b =>
                {
                    b.Property<int>("IdInforme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_informe");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInforme"), 1L, 1);

                    b.Property<string>("NombreInforme")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre_informe");

                    b.Property<string>("Observaciones")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("TipoInforme")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Tipo_informe");

                    b.HasKey("IdInforme");

                    b.ToTable("90_Informes_Parametros", (string)null);
                });

            modelBuilder.Entity("WebAdminPortal.Models.DatosParaProcesar", b =>
                {
                    b.Property<string>("CodMatriculaContenedor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Cod_Matricula_Contenedor");

                    b.Property<int?>("Diff")
                        .HasColumnType("int");

                    b.Property<int?>("DiffAct")
                        .HasColumnType("int")
                        .HasColumnName("Diff_ACT");

                    b.Property<string>("Evento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Expr4")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaActual")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_Actual");

                    b.Property<DateTime?>("FechaActualTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_actual_time");

                    b.Property<DateTime?>("FechaActualizaciónRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_Actualización_Registro");

                    b.Property<DateTime?>("FechaExpec")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_Expec");

                    b.Property<DateTime?>("FechaExpectedTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_expected_time");

                    b.Property<DateTime?>("FectAct")
                        .HasColumnType("datetime")
                        .HasColumnName("Fect_act");

                    b.Property<string>("Navieras")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Numero_Operacion");

                    b.Property<string>("TipoEvento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Tipo_Evento");

                    b.Property<string>("Usuario")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.ToView("Datos_Para_Procesar");
                });

            modelBuilder.Entity("WebAdminPortal.Models.DistinctOpContainerNav", b =>
                {
                    b.Property<string>("CodMatriculaContenedor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Cod_Matricula_Contenedor");

                    b.Property<string>("Navieras")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Numero_Operacion");

                    b.Property<string>("Usuario")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.ToView("Distinct_OP_Container_Nav");
                });

            modelBuilder.Entity("WebAdminPortal.Models.OperacionesAProcesar", b =>
                {
                    b.Property<string>("CodMatriculaContenedor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Cod_Matricula_Contenedor");

                    b.Property<string>("Flujo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Navieras")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NumeroOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Numero_Operacion");

                    b.Property<string>("Usuario")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.ToView("Operaciones_a_Procesar");
                });

            modelBuilder.Entity("WebAdminPortal.Models.RnkMovOpe", b =>
                {
                    b.Property<string>("DidCodMatriculaContenedor")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DID_Cod_Matricula_Contenedor");

                    b.Property<string>("DidNumeroOperacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("DID_Numero_Operacion");

                    b.Property<DateTime?>("FechaActualTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_actual_time");

                    b.Property<DateTime?>("FechaActualizaciónRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_Actualización_Registro");

                    b.Property<DateTime?>("FechaExpectedTime")
                        .HasColumnType("datetime")
                        .HasColumnName("Fecha_expected_time");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long?>("Rnk")
                        .HasColumnType("bigint")
                        .HasColumnName("rnk");

                    b.Property<string>("TipoEvento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Tipo_Evento");

                    b.ToView("RNK_MOV_OPE");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAdminPortal.Models._80UsuarioInforme", b =>
                {
                    b.HasOne("WebAdminPortal.Models._90InformesParametro", "IdInformeNavigation")
                        .WithMany("_80UsuarioInformes")
                        .HasForeignKey("IdInforme")
                        .HasConstraintName("FK_80_Usuario_informe_90_Informes_Parametros");

                    b.Navigation("IdInformeNavigation");
                });

            modelBuilder.Entity("WebAdminPortal.Models._90InformesParametro", b =>
                {
                    b.Navigation("_80UsuarioInformes");
                });
#pragma warning restore 612, 618
        }
    }
}
