using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa: IRepositorioEmpresa
    {
<<<<<<< HEAD
        ///<sumary>
        /// Referencia al contexto del paciente
        /// </sumary>
        
        //private readonly AppContext appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//

        
        public EmpresaVeterinaria AddEmpresa(EmpresaVeterinaria Empresa)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EmpresaVeterinariaAdicionada= _appContext.Empresa.Add(Empresa);
            Context.SaveChanges();
=======
        public EmpresaVeterinaria AddEmpresa(EmpresaVeterinaria Empresa)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EmpresaVeterinariaAdicionada= Contexto.Empresa.Add(Empresa);
            Contexto.SaveChanges();
>>>>>>> 18e9966b9d8b436aff921354ed213c854d23bd33
            return EmpresaVeterinariaAdicionada.Entity;
            }
        }
        public void DeleteEmpresa(int IdEmpresa)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EmpresaVeterinariaEncontrada= Contexto.Empresa.SingleOrDefault(ev => ev.Id==IdEmpresa);
            if (EmpresaVeterinariaEncontrada == null)
            return ;
            Contexto.Empresa.Remove(EmpresaVeterinariaEncontrada);
            Contexto.SaveChanges();
            }
        }
        public IEnumerable<EmpresaVeterinaria> GetAllEmpresa()
        {
             using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
                var GetAllEmpresa= (from g in Contexto.Empresa select g).ToList();
                return GetAllEmpresa;
             }
        }
        public EmpresaVeterinaria GetEmpresa(int IdEmpresa)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            return Contexto.Empresa.SingleOrDefault(ev => ev.Id==IdEmpresa);
            }
        }
        public EmpresaVeterinaria UpdateEmpresa(EmpresaVeterinaria Empresa)
        {
            using (AppRepositorios.AppContext Contexto= new AppRepositorios.AppContext()){
            var EmpresaEncontrada= Contexto.Empresa.SingleOrDefault(ev => ev.Id==Empresa.Id);
            if (EmpresaEncontrada!= null)
            {
                EmpresaEncontrada.Nit=EmpresaEncontrada.Nit;
                EmpresaEncontrada.RazonSocial=EmpresaEncontrada.RazonSocial;
                EmpresaEncontrada.Direccion=EmpresaEncontrada.Direccion;
                Contexto.SaveChanges();
            }
            return EmpresaEncontrada;
            }
        }
    }
}