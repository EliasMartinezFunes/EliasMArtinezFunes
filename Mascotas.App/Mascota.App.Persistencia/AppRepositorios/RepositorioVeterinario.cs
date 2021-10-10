using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario
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

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext=appContext;
        }
        public Veterinario AddVeterinario(Veterinario Veterinario)
        {
            var VeterinarioAdicionado= _appContext.Veterinario.Add(Veterinario);
            _appContext.SaveChanges();
            return VeterinarioAdicionado.Entity;
        }
        public void DeleteVeterinario(int IdVeterinario)
        {
            var VeterinarioEncontrado=_appContext.Veterinario.FirstOrDefault(v => v.Id==IdVeterinario);
            if(VeterinarioEncontrado == null)
            return ;
            _appContext.Veterinario.Remove(VeterinarioEncontrado);
            _appContext.SaveChanges();
        }
        public IEnumerable<Veterinario> GetAllVeterinario()
        {
             using (Repositorios.Appcontext Contexto= new AppRepositorio.AppContext()){
                var ListadoVeterinario= (from v in Contexto.Veterinario select v).ToList();
                return ListadoVeterinario;
        }
        public Veterinario GetVeterinario(int IdVeterinario)
        {
            return _appContext.Veterinario.FirstOrDefault(v => v.Id==IdVeterinario);
        }
        public Veterinario UpdateVeterinario(Veterinario Veterinario)
        {
            var VeterinarioEncontrado=_appContext.Veterinario.FirstOrDefault(v => v.Id==Veterinario.Id);
            if(VeterinarioEncontrado!=null)
            {
                VeterinarioEncontrado.TarjetaProfesional=VeterinarioEncontrado.TarjetaProfesional;
                VeterinarioEncontrado.Especializacion=VeterinarioEncontrado.Especializacion;
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        } 
    }
}