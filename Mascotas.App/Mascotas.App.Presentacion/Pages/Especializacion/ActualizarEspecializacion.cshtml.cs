using System;
using System.Collections.Generic;
using System.Linq;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.App.Presentacion.Pages
{
    public class ActualizarEspecializacionModel : PageModel
    {
         private readonly IRepositorioEspecializacion repositorio;
         public Especializacion Especializaciones{get;set;}
         public ActualizarEspecializacionModel(IRepositorioEspecializacion repositorio){
             this.repositorio=repositorio;
             }
        public IActionResult OnGet(int Id)
        {
            Especializaciones=repositorio.GetEspecializaciones(Id);
            if (Especializaciones==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost(Especializacion Especializaciones)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(Especializaciones.Id>0){
            repositorio.UpdateEspecializaciones(Especializaciones);
          }
            return RedirectToPage("./ListaEspecializacion");
          
        }
    }
}
