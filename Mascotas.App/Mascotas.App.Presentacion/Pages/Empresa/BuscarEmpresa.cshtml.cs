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
    public class BuscarEmpresaModel : PageModel
    {
    private readonly IRepositorioEmpresa repositorio;
         public Mascota.App.Dominio.Entidades.EmpresaVeterinaria Empresa{get;set;}
        public BuscarEmpresaModel(IRepositorioEmpresa repositorio){
            this.repositorio=repositorio;
        }
        public IActionResult OnGet(int Id)
        {
            Empresa=repositorio.GetEmpresa(Id);
            if(Empresa==null){
                return RedirectToPage("./PaginaNoEncontrada");
            }
            else{
                return Page();
            }
        }
    }
}
