using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();
        //Agregar
        Persona AddPersona(Persona persona);
        //Actualizar
        Persona UpdatePersona(Persona persona);
        //Eliminar persona
        void DeletePersona(int IdPersona);
        //Buscar persona
        Persona GetPersona(int IdPersona);
    }
}