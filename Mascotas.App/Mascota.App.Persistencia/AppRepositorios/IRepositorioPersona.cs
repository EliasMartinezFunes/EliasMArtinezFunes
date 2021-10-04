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
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int IdPersona);
        Persona GetPersona(int IdPersona);
    }
}