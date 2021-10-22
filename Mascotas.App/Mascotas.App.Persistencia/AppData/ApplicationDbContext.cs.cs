using Microsoft.EntityFrameworkCore;
using Mascotas.App.Dominio.Entidades;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Mascotas.App.Persistencia
{
    /// <summary>
    //Propiedad
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ClaseMedicoVeterinario> medicosVeterinarios {get;set;}
        public DbSet<ClaseDuenoMascota> duenosMascotas {get;set;}
        ///El tipo 'ClaseTipoAnimal' debe ser un tipo de referencia para poder usarlo como parámetro
        /// ///public DbSet<ClaseTipoAnimal> TipoAnimal {get;set;}
        public DbSet<ClaseMascota > mascotas {get;set;}
        public DbSet<ClaseVisitaVeterinaria > visitasVeterinarias {get;set;}
        public DbSet<ClaseEmpresa> empresas {get;set;}
        public DbSet<ClaseEstadoMascota> estadosMascotas {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            //cadena de conexion
            {
                ///optionsBuilder.UseSqlServer("Data Source = FINA; Initial Catalog = HospiEnCasa;User Id=FINA\Familia; password=''")
                //optionsBuilder.UseSqlServer(@"Server = (localdb)\\mssqllocaldb; Database = Mascotas");
                optionsBuilder.UseSqlServer(" Data Source = FINA; Initial Catalog = Mascotas; Trusted_Connection=true;");
            }
        }
    }
}