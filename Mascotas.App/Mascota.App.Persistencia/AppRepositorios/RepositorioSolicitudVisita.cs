using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioSolicitudVisita: IRepositorioSolicitudVisita
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

        public RepositorioSolicitudVisita(AppContext appContext)
        {
            _appContext=appContext;
        }
        public SolicitudVisita AddSolicitud(SolicitudVisita Solicitud)
        {
            var SolicitudAdicinada= _appContext.Solicitud.Add(Solicitud);
            _appContext.SaveChanges();
            return SolicitudAdicinada.Entity;
        }
        public void DeleteSolicitud(int IdSolicitud)
        {
            var SolicitudEncontrada= _appContext.Solicitud.FirstOrDefault(s => s.Id==IdSolicitud);
            if(SolicitudEncontrada==null)
            return;
            _appContext.Solicitud.Remove(SolicitudEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<SolicitudVisita> GetAllSolicitud()
        {
             using (Repositorios.Appcontext Contexto= new AppRepositorio.AppContext()){
                var ListadoSolicitud= (from s in Contexto.Solicitud select s).ToList();
                return ListadoSolicitud;
        }
        public SolicitudVisita GetSolicitud(int IdSolicitud)
        {
            return _appContext.Solicitud.FirstOrDefault(s => s.Id==IdSolicitud);
        }
        public SolicitudVisita UpdateSolicitud(SolicitudVisita Solicitud)
        {
            var SolicitudEncontrada=_appContext.Solicitud.FirstOrDefault(s => s.Id==Solicitud.Id);
            if(SolicitudEncontrada!= null)
            {
                SolicitudEncontrada.IdDueño=Solicitud.IdDueño;
                SolicitudEncontrada.NombreMascota=Solicitud.NombreMascota;
                SolicitudEncontrada.TipoMascota=Solicitud.NombreMascota;
                SolicitudEncontrada.Veterinario=Solicitud.Veterinario;
                SolicitudEncontrada.FechaVisita=Solicitud.FechaVisita;
                _appContext.SaveChanges();
            }
            return SolicitudEncontrada;
        } 

    } 
}