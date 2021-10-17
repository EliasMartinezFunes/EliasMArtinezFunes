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
        
        //private readonly AppContext _appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//

        public Persona AddPersona(Persona persona)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var personaEncontrada= Contexto.Persona.Add(persona);
            Contexto.SaveChanges();
            return personaEncontrada.Entity;
            }
        }
        public void DeletePersona(int IdPersona)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var personaEncontrada= Contexto.Persona.SingleOrDefault(p => p.Id==IdPersona);
            if(personaEncontrada == null)
            return;
            Contexto.Persona.Remove(personaEncontrada);
            Contexto.SaveChanges();
            }
        }
        public IEnumerable<Persona> GetAllPersona(){
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllPersona= (from p in Contexto.Persona select p).ToList();
                return GetAllPersona;
                // se cambio Listado persona por GetAllPersona
        
            }
        }
        //Metodo buscar persona por id
        public Persona GetPersona(int IdPersona)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
               // var GetPersona= (from p in Contexto.persona where p.IdPersona==IdPersona select p);
               // return GetPersona;
            return Contexto.Persona.SingleOrDefault(p => p.Id==IdPersona);
            }
        }
        public Persona UpdatePersona(Persona persona)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var personaEncontrada= Contexto.Persona.SingleOrDefault(p => p.Id==persona.Id);
            if (personaEncontrada!=null)
            {
                personaEncontrada.Nombre=persona.Nombre;
                personaEncontrada.DocId=persona.DocId;
                personaEncontrada.Apellidos=persona.Apellidos;
                personaEncontrada.Telefono=persona.Telefono;
                personaEncontrada.Direccion=persona.Direccion;

                Contexto.SaveChanges();
            }
            return personaEncontrada;
            }
        }
      
    }
}