using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Mascota.App.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa: IRepositorioEmpresa
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

        public RepositorioEmpresa(AppContext appContext)
        {
            _appContext=appContext;
        }
        public EmpresaVeterinaria AddEmpresa(EmpresaVeterinaria Empresa)
        {
            var EmpresaVeterinariaAdicionada= _appContext.Empresa.Add(Empresa);
            _appContext.SaveChanges();
            return EmpresaVeterinariaAdicionada.Entity;
        }
        public void DeleteEmpresa(int IdEmpresa)
        {
            var EmpresaVeterinariaEncontrada= _appContext.Empresa.FirstOrDefault(ev => ev.Id==IdEmpresa);
            if (EmpresaVeterinariaEncontrada == null)
            return ;
            _appContext.Empresa.Remove(EmpresaVeterinariaEncontrada);
            _appContext.SaveChanges();
        }
        public IEnumerable<EmpresaVeterinaria> GetAllEmpresa()
        {
            return _appContext.Empresa;
        }
        public EmpresaVeterinaria GetEmpresa(int IdEmpresa)
        {
            return _appContext.Empresa.FirstOrDefault(ev => ev.Id==IdEmpresa);
        }
        public EmpresaVeterinaria UpdateEmpresa(EmpresaVeterinaria Empresa)
        {
            var EmpresaEncontrada= _appContext.Empresa.FirstOrDefault(ev => ev.Id==Empresa.Id);
            if (EmpresaEncontrada!= null)
            {
                EmpresaEncontrada.Nit=EmpresaEncontrada.Nit;
                EmpresaEncontrada.RazonSocial=EmpresaEncontrada.RazonSocial;
                EmpresaEncontrada.Direccion=EmpresaEncontrada.Direccion;
                _appContext.SaveChanges();
            }
            return EmpresaEncontrada;
        }
    }
}