using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioSolicitudVisita
    {
        IEnumerable<SolicitudVisita> GetAllSolicitud();
        SolicitudVisita AddSolicitud(SolicitudVisita Solicitud);
        SolicitudVisita UpdateSolicitud(SolicitudVisita Solicitud);
        void DeleteSolicitud(int IdSolicitud);
        SolicitudVisita GetSolicitud(int IdSolicitud);
    }
}