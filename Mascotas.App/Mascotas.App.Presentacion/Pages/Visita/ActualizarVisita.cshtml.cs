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
    public class ActualizarVisitaModel : PageModel
    {
         private readonly IRepositorioVisitaVeterinario repositorio;
        public VisitaVeterinario Visitas{get;set;}
        public ActualizarVisitaModel(IRepositorioVisitaVeterinario repositorio){
            this.repositorio=repositorio;
        }
        public IActionResult OnGet(int Id)
        {
            Visitas=repositorio.GetVisitas(Id);
            if (Visitas==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost(VisitaVeterinario Visitas)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(Visitas.Id>0){
            repositorio.UpdateVisitas(Visitas);
          }
            return RedirectToPage("./ListaVisita");
          
        }
    }
}
