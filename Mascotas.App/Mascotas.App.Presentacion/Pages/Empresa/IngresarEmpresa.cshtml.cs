using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;

namespace Mascotas.App.Presentacion.Pages
{
    public class IngresarEmpresaModel : PageModel
    {
        [BindProperty]
        public Mascota.App.Dominio.Entidades.EmpresaVeterinaria Empresa{get;set;}
        private readonly IRepositorioEmpresa repositorio;
        public void OnGet()
        {
        }
        public IngresarEmpresaModel(IRepositorioEmpresa repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            Empresa=repositorio.AddEmpresa(Empresa);
        }
    }
}
