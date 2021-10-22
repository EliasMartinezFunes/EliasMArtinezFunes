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
    public class ActualizarVeterinarioModel : PageModel
    {
          private readonly IRepositorioVeterinario repositorio;
         public Veterinario Veterinario{get;set;}
         public ActualizarVeterinarioModel(IRepositorioVeterinario repositorio){
             this.repositorio=repositorio;
             }
        public IActionResult OnGet(int Id)
        {
            Veterinario=repositorio.GetVeterinario(Id);
            if (Veterinario==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost(Veterinario veterinario)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(veterinario.Id>0){
            repositorio.UpdateVeterinario(veterinario);
          }
            return RedirectToPage("./ListaVeterinario");
          
        }
    }
}
