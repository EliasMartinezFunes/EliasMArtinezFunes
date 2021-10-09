using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioVisitaVeterinario: IRepositorioVisitaVeterinario
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

        public RepositorioVisitaVeterinario(AppContext appContext)
        {
            _appContext=appContext;
        }
        public VisitaVeterinario AddVisitas(VisitaVeterinario Visitas)
        {
            var VisitasAdicionada= _appContext.Visitas.Add(Visitas);
            _appContext.SaveChanges();
            return VisitasAdicionada.Entity;
        }
        public void DeleteVisitas(int IdVisitas)
        {
            var VisitasEncontrada= _appContext.Visitas.FirstOrDefault(o => o.Id==IdVisitas);
            if(VisitasEncontrada == null)
            return ;
            _appContext.Visitas.Remove(VisitasEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<VisitaVeterinario> GetAllVisitas()
        {
            return _appContext.Visitas;
        }
        public VisitaVeterinario GetVisitas(int IdVisitas)
        {
            return _appContext.Visitas.FirstOrDefault(o => o.Id==IdVisitas);
        }
        public VisitaVeterinario UpdateVisitas(VisitaVeterinario Visitas)
        {
            var VisitasEncontrada= _appContext.Visitas.FirstOrDefault(o => o.Id== Visitas.Id);
            if(VisitasEncontrada!= null)
            {
                
                VisitasEncontrada.Fecha=Visitas.Fecha;
                VisitasEncontrada.Temperatura=Visitas.Temperatura;
                VisitasEncontrada.Peso=Visitas.Peso;
                VisitasEncontrada.FrecuenciaRespiratoria= Visitas.FrecuenciaRespiratoria;
                VisitasEncontrada.FrecuenciaCardiaca=Visitas.FrecuenciaCardiaca;
                VisitasEncontrada.EstadoAnimal=Visitas.EstadoAnimal;
                VisitasEncontrada.IdVeterinario= Visitas.IdVeterinario;
                VisitasEncontrada.Recomendacion=Visitas.Recomendacion;
                _appContext.SaveChanges();
            }
            return VisitasEncontrada;
        }
    }
}