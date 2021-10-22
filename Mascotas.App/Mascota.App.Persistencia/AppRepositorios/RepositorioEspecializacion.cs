using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioEspecializacion: IRepositorioEspecializacion
    {
<<<<<<< HEAD
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
=======
>>>>>>> 18e9966b9d8b436aff921354ed213c854d23bd33
        public Especializacion AddEspecializaciones(Especializacion Especializaciones)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EspeAdicionada= Contexto.Especializaciones.Add(Especializaciones);
            Contexto.SaveChanges();
            return EspeAdicionada.Entity;
            }
        }
        public void DeleteEspecializaciones(int IdEspecializaciones)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EspeEncontrada= Contexto.Especializaciones.SingleOrDefault(e => e.Id==IdEspecializaciones);
            if (EspeEncontrada== null)
            return;
            Contexto.Especializaciones.Remove(EspeEncontrada);
            Contexto.SaveChanges();
            }
        }
        public IEnumerable<Especializacion> GetAllEspecializaciones()
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllEspecializaciones= (from e in Contexto.Especializaciones select e).ToList();
                return GetAllEspecializaciones;
            }
        }
        public Especializacion GetEspecializaciones(int IdEspecializaciones)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            return Contexto.Especializaciones.SingleOrDefault(e => e.Id==IdEspecializaciones);
            }
        }
        public Especializacion UpdateEspecializaciones(Especializacion especializacion)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EspeEncontrada= Contexto.Especializaciones.SingleOrDefault(especializacion => especializacion.Id==especializacion.Id);
            if (EspeEncontrada!=null)
            {
                EspeEncontrada.Aves=especializacion.Aves;
                EspeEncontrada.Gatos=especializacion.Gatos;
                EspeEncontrada.Perros=especializacion.Perros;
                Contexto.SaveChanges();
            }
            return EspeEncontrada;
            }
        }
    }
}