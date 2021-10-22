using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona: IRepositorioPersona
    {
        //Metodo Agregar
        public Persona AddPersona(Persona persona)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var personaEncontrada= Contexto.Persona.Add(persona);
            Contexto.SaveChanges();
            return personaEncontrada.Entity;
            }
        }
        //Metodo Eliminar
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
        //Metodo Actualizar
        public Persona UpdatePersona(Persona personas)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var personaEncontrada= Contexto.Persona.FirstOrDefault(p => p.Id==personas.Id);
            if (personaEncontrada!=null)
            {
                personaEncontrada.Nombre=personas.Nombre;
                personaEncontrada.DocId=personas.DocId;
                personaEncontrada.Apellidos=personas.Apellidos;
                personaEncontrada.Telefono=personas.Telefono;
                personaEncontrada.Direccion=personas.Direccion;

                Contexto.SaveChanges();
            }
            return personaEncontrada;
            }
        }
      
    }
}