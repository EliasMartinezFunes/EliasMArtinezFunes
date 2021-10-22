using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascotas.App.Dominio.Entidades;
using Mascotas.App.Persistencia.AppRepositorios;
using Microsoft.EntityFrameworkCore;

namespace Mascotas.App.Persistencia.AppRepositorios
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        ///<sumary>
        /// Referencia al contexto del paciente
        /// </sumary>
        //private readonly ApplicationDbContext appContext;
        ///<sumary>
        /// Metodo constructor a utilizar
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </sumary>
        ///<param name="appContext"></param>//
        /*public RepositorioEmpresa(AppContext appContext)
        {
            this._appContext=appContext;
        }*/
        //Implementando la funcionalidad al metodo de la interface
        public ClaseEmpresa AddClasEmpresa(ClaseEmpresa empresa)
        {
            //Insert
            using (
                ApplicationDbContext _appContext = new ApplicationDbContext { }
            )
            {
                //EmpresaAdicionada objEmpresa= -appContext.Empresas({
                //Nit = 12345,
                //RazonSocial = "Pepito",
                // Direccion = "c343k23"
                //})
                //Persona._appContex.Add(Objpersona);
                //_appContext.SaveChanges();
                var EmpresaAdicionada = _appContext.Add(empresa);
                _appContext.SaveChanges();

                /* bool valorRetorno=false;
                if(_appContext.SaveChanges()>=1)
                {
                     valorRetorno=true;               
                }
                return ValorRetorno;*/
                return EmpresaAdicionada.Entity;
            }
        }

        //Consultar todas las Personas
        public IEnumerable<ClaseEmpresa> GetAllEmpresa()
        {
            using (
                ApplicationDbContext _appContext = new ApplicationDbContext { }
            )
            {
                //Error Tolistt no esta implementada.
                var ListaEmpresa =
                    (from em in _appContext.empresas select em).ToList();
                return ListaEmpresa;
                //return _appContext.empresas;
            }
        }

        //Consultar una persona segun su Id y retornar
        public ClaseEmpresa GetClaseEmpresa(long nit)
        {
            //Estructura video:
            // return _appContext.Empresa.FirstOrDefault(ev => ev.Id==IdEmpresa);
            using (
                ApplicationDbContext _appContext = new ApplicationDbContext { }
            )
            {
                var ListaEmpresa =
                    _appContext.empresas.FirstOrDefault(ev => ev.nit == nit);

                //var ListaEmpresa =(from em in _appContext.empresas where em.nit==nit select em).ToList();
                //var ListaEmpresa=(from em in _appContext.Empresas).where (em=>em.nit=empresas.nit);

                return ListaEmpresa;
            }
        }

        public void DeleteClaseEmpresa(long nit)
        {
            using (
                ApplicationDbContext _appContext = new ApplicationDbContext { }
            )
            {
             /*var EmpresaBusqueda =
                    (
                    from em in _appContext.empresas
                    where em.nit == nit select em
                    );*/

                var EmpresaBusqueda= _appContext.empresas.FirstOrDefault(ev => ev.nit==nit);
                if (!(EmpresaBusqueda == null))
                {
                    _appContext.empresas.Remove(EmpresaBusqueda);
                    _appContext.SaveChanges();
                }
                return;
            }
        }

        //Implementar lo de actualizar para la Empresas
        public ClaseEmpresa UpdateClasEmpresa(ClaseEmpresa empresas)
        {
            using( ApplicationDbContext _appContext =new ApplicationDbContext{} )
            {
                var EmpresaEncontrada= _appContext.empresas.FirstOrDefault(ev => ev.nit==empresas.nit);
                //linq:Lenguaje estructurado
                //var EmpresaEncontrada=(from em in _appContext.empresas where em.nit==empresas.nit select em);
                //var EmpresaEncontrada=(from em in _appContext.empresas where em.nit==nit select em);
                //if (EmpresaEncontrada!= null)
                /*var EmpresaEncontrada =
                    (
                    from em in _appContext.empresas
                    where em.nit == empresas.nit select em
                    );*/
                if (!(EmpresaEncontrada == null))
                {
                    EmpresaEncontrada.nit=empresas.nit;
                    EmpresaEncontrada.razonSocial=empresas.razonSocial;
                    EmpresaEncontrada.direccion=empresas.direccion;
                }
                _appContext.SaveChanges();
                return EmpresaEncontrada;
                
            }
        }
       
    }
}
