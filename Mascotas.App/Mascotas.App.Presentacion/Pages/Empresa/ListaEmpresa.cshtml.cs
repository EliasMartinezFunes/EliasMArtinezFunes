using System;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.App.Presentacion.Pages
{
    public class ListaEmpresaModel : PageModel
    {
        private readonly IRepositorioEmpresa repositorio;
         public IEnumerable<Mascota.App.Dominio.Entidades.EmpresaVeterinaria> Empresa = new List<Mascota.App.Dominio.Entidades.EmpresaVeterinaria>();
       
        public void OnGet()
        {
            Empresa=repositorio.GetAllEmpresa();
        }
        public ListaEmpresaModel(IRepositorioEmpresa repositorio){
            this.repositorio=repositorio;
        }
    }
}
