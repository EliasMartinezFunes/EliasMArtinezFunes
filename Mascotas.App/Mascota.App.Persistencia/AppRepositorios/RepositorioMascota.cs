using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioMascota: IRepositorioMascota
    {
        public Animal AddAnimals(Animal animals)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var AnimalsAdicionada= Contexto.Animals.Add(animals);
            Contexto.SaveChanges();
            return AnimalsAdicionada.Entity;
            }

        }
        public void DeleteAnimals(int IdAnimals)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var AnimalEncontrada= Contexto.Animals.SingleOrDefault(m => m.Id==IdAnimals);
            if (AnimalEncontrada == null)
            return ;
            Contexto.Animals.Remove(AnimalEncontrada);
            Contexto.SaveChanges();
            }
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
             using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllAnimals= (from a in Contexto.Animals select a).ToList();
                return GetAllAnimals;
             }
        }
        public Animal GetAnimals(int IdAnimals)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            return Contexto.Animals.SingleOrDefault(m => m.Id==IdAnimals);
            }
        }
        public Animal UpdateAnimals(Animal Animal)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
             var AnimalEncontrada= Contexto.Animals.SingleOrDefault(m => m.Id==Animal.Id);
            if (AnimalEncontrada!=null)
            {
                AnimalEncontrada.Nombres=Animal.Nombres;
                AnimalEncontrada.TipoAnimal=Animal.TipoAnimal;
                AnimalEncontrada.ColorOjos=Animal.ColorOjos;
                AnimalEncontrada.ColorPiel=Animal.ColorPiel;
                AnimalEncontrada.Estatura=Animal.Estatura;
                AnimalEncontrada.Raza=Animal.Raza;
                Contexto.SaveChanges();
            }
            return AnimalEncontrada;
            }
        }

     }
}