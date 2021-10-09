using System;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEspecializacion
    {
        IEnumerable<Especializacion> GetAllEspecializaciones();
        Especializacion AddEspecializaciones(Especializacion Especializaciones);
        Especializacion UpdateEspecializaciones(Especializacion Especializaciones);
        void DeleteEspecializaciones(int IdEspecializaciones);
        Especializacion GetEspecializaciones(int IdEspecializaciones);
   }
}