using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia.AppRepositorios
{
    public interface IRepositorioDuenoMascota
    {
        IEnumerable<ClaseDuenoMascota> GetAllDuenoMascota();
        ClaseDuenoMascota AddClaseDuenoMascota(ClaseDuenoMascota DuenoMascota);
        ClaseDuenoMascota UpdateClaseDuenoMascota(ClaseDuenoMascota DuenoMascota);
        void DeleteClaseDuenoMascota(int identificacion);
        ClaseDuenoMascota GetClaseDuenoMascota(int identificacion);
    }
}