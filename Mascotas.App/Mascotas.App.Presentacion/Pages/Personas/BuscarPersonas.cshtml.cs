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
    public class BuscarPersonasModel : PageModel
    {
         private readonly IRepositorioPersona repositorio;
         public Mascota.App.Dominio.Entidades.Persona personas{get;set;}
         public BuscarPersonasModel(IRepositorioPersona repositorio){
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
    }
}
