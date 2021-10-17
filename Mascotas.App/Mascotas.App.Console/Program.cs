using System;
using Mascota.App.Dominio.Entidades;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Persistencia;
using System.Linq;


namespace Mascotas.App.Console
{
    class Program
    {
        public static IRepositorioMascota _repoMascota= new RepositorioMascota(new Mascota.App.Persistencia.AppRepositorios.AppContext());
        public static IRepositorioPersona _repoPersona= new RepositorioPersona(new Mascota.App.Persistencia.AppRepositorios.AppContext());
        public static IRepositorioEspecializacion _repoEspe= new RepositorioEspecializacion(new  Mascota.App.Persistencia.AppRepositorios.AppContext());
        public static IRepositorioEmpresa _repoEmpresa= new RepositorioEmpresa(new Mascota.App.Persistencia.AppRepositorios.AppContext());
        public static IRepositorioSolicitudVisita _repoSolicitud= new RepositorioSolicitudVisita(new Mascota.App.Persistencia.AppRepositorios.AppContext());
        public static IRepositorioVisitaVeterinario _repoVisitas= new RepositorioVisitaVeterinario(new Mascota.App.Persistencia.AppRepositorios.AppContext());
        

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World EF!");
            AddAnimals();
            AddPersona();
            AddEspecializacion();
            AddEmpresa();
            AddSolicitud();
            AddVisitas();
            
        }
        private static void AddAnimals()
        {
            var Animals= new Animal
            {
                Nombres = "Pasta",
                TipoAnimal = "Aves",
                ColorOjos = "Cafes",
                ColorPiel = "Roja",
                Estatura = "25 cm",
                Raza = "Papuja"
            };
            _repoMascota.AddAnimals(Animals);
        }
        
        
        private static void AddPersona()
        {
            var persona= new Persona
            {
            DocId= "677698",
            Nombre="Eduardo",
            Apellidos= "Castro",
            Telefono="889977",
            Direccion="Tierralta"
            };
            _repoPersona.AddPersona(persona);

        }
        private  static void AddEspecializacion()
        {
            var Especializaciones= new Especializacion
            {
                Aves= "Avicola",
                Gatos="Felinos",
                Perros="Caninos"
            };
            _repoEspe.AddEspecializaciones(Especializaciones);
        }
        private static void AddEmpresa()
        {
            var Empresa= new EmpresaVeterinaria
            {
                Nit=098765444,
                RazonSocial="Mandamas",
                Direccion="Av Primera"
            };
            _repoEmpresa.AddEmpresa(Empresa);
        }
        private static void AddSolicitud()
        {
            var Solicitud= new SolicitudVisita
            {
                IdDueño="2",
                NombreMascota= "Garrote",
                TipoMascota="Perros",
                Veterinario="Carlos",
                FechaVisita="4-10-2021"
            };
            _repoSolicitud.AddSolicitud(Solicitud);
        }
        private static void AddVisitas()
        {
            var Visitas= new VisitaVeterinario
            {   
                
                Temperatura="38",
                Peso="40",
                FrecuenciaRespiratoria="74",
                FrecuenciaCardiaca="120/80",
                EstadoAnimal="Sano",
                IdVeterinario="2",
                Recomendacion="No Sofocar"
            };
            _repoVisitas.AddVisitas(Visitas);
        }
        private static void AddVeterinario()
        {
            var Veterinario= new Veterinario
            {
                TarjetaProfesional="9'98yyh",
                Especializacion="Gatos"
            };
            _repoPersona.AddPersona(Veterinario);
        }
    }
}

    
