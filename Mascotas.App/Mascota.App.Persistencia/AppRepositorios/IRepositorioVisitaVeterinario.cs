using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioVisitaVeterinario
    {
        IEnumerable<VisitaVeterinario> GetAllVisitas();
        VisitaVeterinario AddVisitas(VisitaVeterinario Visitas);
        VisitaVeterinario UpdateVisitas(VisitaVeterinario Visitas);
        void DeleteVisitas(int IdVisitas);
        VisitaVeterinario GetVisitas(int IdVisitas);
    }
}