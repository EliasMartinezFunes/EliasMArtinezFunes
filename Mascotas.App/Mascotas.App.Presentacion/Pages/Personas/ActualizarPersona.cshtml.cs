using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.App.Presentacion.Pages
{
    public class ActualizarPersonaModel : PageModel
    {
           private readonly IRepositorioPersona repositorio;
         public Persona personas{get;set;}
         public ActualizarPersonaModel(IRepositorioPersona repositorio){
             this.repositorio=repositorio;
             }
        public IActionResult OnGet(int Id)
        {
            personas=repositorio.GetPersona(Id);
            if (personas==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost(Persona personas)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(personas.Id>0){
            repositorio.UpdatePersona(personas);
          }
            return RedirectToPage("./Personas");
          
        }
    }
}
