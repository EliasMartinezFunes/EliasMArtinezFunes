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
    public class BuscarVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorio;
         public Mascota.App.Dominio.Entidades.Veterinario Veterinario{get;set;}
         public BuscarVeterinarioModel(IRepositorioVeterinario repositorio){
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
    }
}
