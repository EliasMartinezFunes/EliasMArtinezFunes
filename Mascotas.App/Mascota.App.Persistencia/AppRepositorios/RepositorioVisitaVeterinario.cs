using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using Mascota.App.Persistencia.AppRepositorios;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioVisitaVeterinario: IRepositorioVisitaVeterinario
    {
        public VisitaVeterinario AddVisitas(VisitaVeterinario Visitas)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var VisitasAdicionada= Contexto.Visitas.Add(Visitas);
            Contexto.SaveChanges();
            return VisitasAdicionada.Entity;
            }
        }
        public void DeleteVisitas(int IdVisitas)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var VisitasEncontrada= Contexto.Visitas.SingleOrDefault(o => o.Id==IdVisitas);
            if(VisitasEncontrada == null)
            return ;
            Contexto.Visitas.Remove(VisitasEncontrada);
            Contexto.SaveChanges();
            }
        }
        public IEnumerable<VisitaVeterinario> GetAllVisitas()
        {
             using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllVisitas= (from i in Contexto.Visitas select i).ToList();
                return GetAllVisitas;
             
             }
        }
        public VisitaVeterinario GetVisitas(int IdVisitas)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            return Contexto.Visitas.SingleOrDefault(o => o.Id==IdVisitas);
            }
        }
        public VisitaVeterinario UpdateVisitas(VisitaVeterinario Visitas)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var VisitasEncontrada= Contexto.Visitas.SingleOrDefault(o => o.Id== Visitas.Id);
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
                Contexto.SaveChanges();
            }
            return VisitasEncontrada;
        }
        }
    }
}