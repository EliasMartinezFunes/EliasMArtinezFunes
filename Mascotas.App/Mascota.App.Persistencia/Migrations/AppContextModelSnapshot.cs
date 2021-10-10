﻿// <auto-generated />
using Mascota.App.Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mascota.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColorOjos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorPiel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAnimal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.EmpresaVeterinaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nit")
                        .HasColumnType("int");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.Especializacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Aves")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gatos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Perros")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especializaciones");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.SolicitudVisita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FechaVisita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdDueño")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Veterinario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Solicitud");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.VisitaVeterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EstadoAnimal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaCardiaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrecuenciaRespiratoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdVeterinario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recomendacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temperatura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.Dueño", b =>
                {
                    b.HasBaseType("Mascota.App.Dominio.Entidades.Persona");

                    b.Property<int>("IdDueño")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Dueño");
                });

            modelBuilder.Entity("Mascota.App.Dominio.Entidades.Veterinario", b =>
                {
                    b.HasBaseType("Mascota.App.Dominio.Entidades.Persona");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });
#pragma warning restore 612, 618
        }
    }
}