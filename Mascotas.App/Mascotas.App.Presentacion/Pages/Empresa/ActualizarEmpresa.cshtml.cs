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
    public class ActualizarEmpresaModel : PageModel
    {
        private readonly IRepositorioEmpresa repositorio;
         public EmpresaVeterinaria Empresa{get;set;}
        public ActualizarEmpresaModel(IRepositorioEmpresa repositorio){
            this.repositorio=repositorio;
        }
        public IActionResult OnGet(int Id)
        {
            Empresa=repositorio.GetEmpresa(Id);
            if (Empresa==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost(EmpresaVeterinaria Empresa)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(Empresa.Id>0){
            repositorio.UpdateEmpresa(Empresa);
          }
            return RedirectToPage("./ListaEmpresa");
          
        }
    }
}
