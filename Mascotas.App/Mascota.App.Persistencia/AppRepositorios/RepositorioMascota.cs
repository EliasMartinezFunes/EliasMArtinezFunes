using Mascota.App.Dominio.Entidades;
//using Mascota.App.Persistencia.AppRepositorios;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota: IRepositorioMascota
    {
        ///<sumary>
        /// Referencia al contexto del paciente
        /// </sumary>
        
        private readonly AppContext _appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//

        public RepositorioMascota(AppContext appContext)
        {
            _appContext=appContext;
        }


        public Animal AddAnimals(Animal animals)
        {
            var AnimalsAdicionada= _appContext.Animals.Add(animals);
            _appContext.SaveChanges();
            return AnimalsAdicionada.Entity;

        }
        public void DeleteAnimals(int IdAnimals)
        {
            var AnimalEncontrada= _appContext.Animals.FirstOrDefault(m => m.Id==IdAnimals);
            if (AnimalEncontrada == null)
            return ;
            _appContext.Animals.Remove(AnimalEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
             using (Repositorios.Appcontext Contexto= new AppRepositorio.AppContext()){
                var ListadoAnimal= (from a in Contexto.Animal select a).ToList();
                return ListadoAnimal;
        }
        public Animal GetAnimals(int IdAnimals)
        {
            return _appContext.Animals.FirstOrDefault(m => m.Id==IdAnimals);
        }
        public Animal UpdateAnimals(Animal Animal)
        {
             var AnimalEncontrada= _appContext.Animals.FirstOrDefault(m => m.Id==Animal.Id);
            if (AnimalEncontrada!=null)
            {
                AnimalEncontrada.Nombres=Animal.Nombres;
                AnimalEncontrada.TipoAnimal=Animal.TipoAnimal;
                AnimalEncontrada.ColorOjos=Animal.ColorOjos;
                AnimalEncontrada.ColorPiel=Animal.ColorPiel;
                AnimalEncontrada.Estatura=Animal.Estatura;
                AnimalEncontrada.Raza=Animal.Raza;
                _appContext.SaveChanges();
            }
            return AnimalEncontrada;
        }

    }
}