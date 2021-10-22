using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioEspecializacion: IRepositorioEspecializacion
    {
        ///<sumary>
        /// Referencia al contexto del paciente
        /// </sumary>
        
        //private readonly AppContext _appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//

        public RepositorioEspecializacion(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Especializacion AddEspecializaciones(Especializacion Especializaciones)
        {
            var EspeAdicionada= _appContext.Especializaciones.Add(Especializaciones);
            _appContext.SaveChanges();
            return EspeAdicionada.Entity;
        }
        public void DeleteEspecializaciones(int IdEspecializaciones)
        {
            var EspeEncontrada= _appContext.Especializaciones.FirstOrDefault(e => e.Id==IdEspecializaciones);
            if (EspeEncontrada== null)
            return;
            _appContext.Especializaciones.Remove(EspeEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<Especializacion> GetAllEspecializaciones()
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var ListadoEspecializaciones= (from e in Contexto.Especializaciones select e).ToList();
                return ListadoEspecializaciones;
            }
        }
        public Especializacion GetEspecializaciones(int IdEspecializaciones)
        {
            return _appContext.Especializaciones.FirstOrDefault(e => e.Id==IdEspecializaciones);
        }
        public Especializacion UpdateEspecializaciones(Especializacion especializacion)
        {
            var EspeEncontrada= _appContext.Especializaciones.FirstOrDefault(especializacion => especializacion.Id==especializacion.Id);
            if (EspeEncontrada!=null)
            {
                EspeEncontrada.Aves=especializacion.Aves;
                EspeEncontrada.Gatos=especializacion.Gatos;
                EspeEncontrada.Perros=especializacion.Perros;
                _appContext.SaveChanges();
            }
            return EspeEncontrada;
        }
    }
}