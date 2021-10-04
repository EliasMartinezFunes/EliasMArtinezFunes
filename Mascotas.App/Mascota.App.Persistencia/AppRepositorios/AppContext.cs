using Microsoft.EntityFrameworkCore;
using Mascota.App.Dominio.Entidades;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Persona {get; set;}
        public DbSet<Dueño> Dueño {get; set;}
        public DbSet<EmpresaVeterinaria> Empresa {get; set;}
        public DbSet<Especializacion> Especializaciones {get; set;}
        public DbSet<Animal> Animals {get; set;}
        public DbSet<SolicitudVisita> Solicitud {get; set;}
        public DbSet<Veterinario> Veterinario {get; set;}
        public DbSet<VisitaVeterinario> Visitas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Mascotas.Data");
            }  
              
        }
        protected override void OnModelCreating(ModelBuilder ModelB)
        {
            ModelB.Entity<VisitaVeterinario>().HasKey(x=>x.Id);
            ModelB.Entity<VisitaVeterinario>().Property(x=>x.Id).ValueGeneratedOnAdd();
            ModelB.Entity<VisitaVeterinario>().ToTable("Visitas");
        }
    }
}