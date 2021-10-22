using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;

namespace Mascotas.App.Persistencia.AppRepositorios
{
    public class RepositorioDuenoMascota : IRepositorioDuenoMascota
    {
        /// <summary>
        /// Referencia al contexto de ClaseDuenoMascota
        /// <summary>
        private readonly AppContext _appContext;

        /// <summary>
        /// Metodo constructor utiliza
        /// Inyección de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="AppContext"></param>//
        

        public RepositorioDuenoMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public  ClaseDuenoMascota AddClaseDuenoMascota(ClaseDuenoMascota DuenoMascota)
        {
            var DuenoMascotaAdicionado =
                _appContext.ClaseDuenoMascota.Add(DuenoMascota);
            _app.Context.SaveChanges();
            return DuenoMascotaAdicionado.Entity;
        }

        public void DeleteClaseDuenoMascota(int identificacion)
        {
            var DuenoMascotaEncontrado =
                _appContext
                    .ClaseDuenoMascota
                    .FirstOrDefault(ma => ma.identificacion == identificacion);
            if (DuenoMascotaEncontrado == null) return;
            _appContext.DuenosMascotas.Remove (DuenoMascotaEncontrado);
            _app.Context.SaveChanges();
        }

        public IEnumerable<ClaseDuenoMascota> GetAllDuenoMascota()
        {
            return _appContext.DuenosMascotas;
        }

        public ClaseDuenoMascota GetClaseDuenoMascota(int identificacion)
        {
            return _appContext
                .ClaseDuenoMascota
                .FirstOrDefault(ma => ma.identificacion == identificacion);
        }

        public ClaseDuenoMascota UpdateClaseDuenoMascota(ClaseDuenoMascota DuenoMascota)
        {
            var DuenoMascotaEncontrado =
                _appContext
                    .ClaseDuenoMascota
                    .FirstOrDefault(p => p.identificacion == DuenoMascota.identificacion);
            if (DuenoMascotaEncontrado != null)
            {
                DuenoMascotaEncontrado.nombre = DuenoMascota.Nombre;
                DuenoMascotaEncontrado.apellido = DuenoMascota.Apellido;
                DuenoMascotaEncontrado.numeroTelefono = DuenoMascota.NumeroTelefono;
                DuenoMascotaEncontrado.direccion = DuenoMascota.Direccion;
                DuenoMascotaEncontrado.mascotas = DuenoMascota.mascotas;
                
            }
            _appContext.SaveChanges();
            return DuenoMascotaEncontrado;
        }
    }
}
