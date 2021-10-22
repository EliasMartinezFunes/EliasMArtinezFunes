using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioVeterinario: IRepositorioVeterinario
    {
       
        public Veterinario AddVeterinario(Veterinario Veterinario)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var VeterinarioAdicionado= Contexto.Veterinario.Add(Veterinario);
            Contexto.SaveChanges();
            return VeterinarioAdicionado.Entity;
            }
        }
        public void DeleteVeterinario(int IdVeterinario)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var VeterinarioEncontrado=Contexto.Veterinario.SingleOrDefault(v => v.Id==IdVeterinario);
            if(VeterinarioEncontrado == null)
            return ;
            Contexto.Veterinario.Remove(VeterinarioEncontrado);
            Contexto.SaveChanges();
            }
        }
        public IEnumerable<Veterinario> GetAllVeterinario()
        {
             using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllVeterinario= (from v in Contexto.Veterinario select v).ToList();
                return GetAllVeterinario;
             }
        }
        public Veterinario GetVeterinario(int IdVeterinario)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            return Contexto.Veterinario.SingleOrDefault(v => v.Id==IdVeterinario);
            }
        }
        public Veterinario UpdateVeterinario(Veterinario Veterinario)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var VeterinarioEncontrado=Contexto.Veterinario.SingleOrDefault(v => v.Id==Veterinario.Id);
            if(VeterinarioEncontrado!=null)
            {
                VeterinarioEncontrado.TarjetaProfesional=VeterinarioEncontrado.TarjetaProfesional;
                VeterinarioEncontrado.Especializacion=VeterinarioEncontrado.Especializacion;
                Contexto.SaveChanges();
            }
            return VeterinarioEncontrado;
            }
        } 
    }
}