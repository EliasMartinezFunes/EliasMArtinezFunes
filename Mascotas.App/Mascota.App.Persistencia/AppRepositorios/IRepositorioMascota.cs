using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Animal> GetAllAnimals();
        Animal AddAnimals(Animal Animals);
        Animal UpdateAnimals(Animal Animals);
        void DeleteAnimals(int IdAnimals);
        Animal GetAnimals(int IdAnimals);

    }
}