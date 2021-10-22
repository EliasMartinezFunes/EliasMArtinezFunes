using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.App.Presentacion.Pages
{
    public class BuscarEspecializacionModel : PageModel
    {
             private readonly IRepositorioEspecializacion repositorio;
         public Mascota.App.Dominio.Entidades.Especializacion Especializaciones{get;set;}
         public BuscarEspecializacionModel(IRepositorioEspecializacion repositorio){
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
    }
}
