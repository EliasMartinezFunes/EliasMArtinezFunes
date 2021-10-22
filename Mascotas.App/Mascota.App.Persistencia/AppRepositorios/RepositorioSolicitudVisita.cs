using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using Mascota.App.Persistencia.AppRepositorios;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioSolicitudVisita: IRepositorioSolicitudVisita
    {
        
        public SolicitudVisita AddSolicitud(SolicitudVisita Solicitud)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var SolicitudAdicinada= Contexto.Solicitud.Add(Solicitud);
            Contexto.SaveChanges();
            return SolicitudAdicinada.Entity;
            }
        }
        public void DeleteSolicitud(int IdSolicitud)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var SolicitudEncontrada= Contexto.Solicitud.SingleOrDefault(s => s.Id==IdSolicitud);
            if(SolicitudEncontrada==null)
            return;
            Contexto.Solicitud.Remove(SolicitudEncontrada);
            Contexto.SaveChanges();
            }
        }
        public IEnumerable<SolicitudVisita> GetAllSolicitud()
        {
             using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllSolicitud= (from s in Contexto.Solicitud select s).ToList();
                return GetAllSolicitud;
             }
        }
        public SolicitudVisita GetSolicitud(int IdSolicitud)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            return Contexto.Solicitud.SingleOrDefault(s => s.Id==IdSolicitud);
            }
        }
        public SolicitudVisita UpdateSolicitud(SolicitudVisita Solicitud)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var SolicitudEncontrada=Contexto.Solicitud.SingleOrDefault(s => s.Id==Solicitud.Id);
            if(SolicitudEncontrada!= null)
            {
                SolicitudEncontrada.IdDueño=Solicitud.IdDueño;
                SolicitudEncontrada.NombreMascota=Solicitud.NombreMascota;
                SolicitudEncontrada.TipoMascota=Solicitud.NombreMascota;
                SolicitudEncontrada.Veterinario=Solicitud.Veterinario;
                SolicitudEncontrada.FechaVisita=Solicitud.FechaVisita;
                Contexto.SaveChanges();
            }
            return SolicitudEncontrada;
            }
        } 

    } 
}