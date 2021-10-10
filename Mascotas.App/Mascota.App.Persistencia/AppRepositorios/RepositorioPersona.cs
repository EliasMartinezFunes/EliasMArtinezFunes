using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona: IRepositorioPersona
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

        public RepositorioPersona(AppContext appContext)
        {
            _appContext= appContext;
        }
        public Persona AddPersona(Persona persona)
        {
            var personaEncontrada= _appContext.Persona.Add(persona);
            _appContext.SaveChanges();
            return personaEncontrada.Entity;
        }
        public void DeletePersona(int IdPersona)
        {
            var personaEncontrada= _appContext.Persona.FirstOrDefault(p => p.Id==IdPersona);
            if(personaEncontrada == null)
            return;
            _appContext.Persona.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<Persona> GetAllPersona()
        {
            using (Repositorios.Appcontext Contexto= new AppRepositorio.AppContext()){
                var ListadoPersona= (from p in Contexto.Persona select p).ToList();
                return ListadoPersona;
        
            }
        }
        public Persona GetPersona(int IdPersona)
        {
            return _appContext.Persona.FirstOrDefault(p => p.Id==IdPersona);
        }
        public Persona UpdatePersona(Persona persona)
        {
            var personaEncontrada= _appContext.Persona.FirstOrDefault(p => p.Id==persona.Id);
            if (personaEncontrada!=null)
            {
                personaEncontrada.Nombre=persona.Nombre;
                personaEncontrada.DocId=persona.DocId;
                personaEncontrada.Apellidos=persona.Apellidos;
                personaEncontrada.Telefono=persona.Telefono;
                personaEncontrada.Direccion=persona.Direccion;

                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
      
    }
}