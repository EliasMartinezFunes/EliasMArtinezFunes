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
    public class BuscarVisitaModel : PageModel
    {
        private readonly IRepositorioVisitaVeterinario repositorio;
         public Mascota.App.Dominio.Entidades.VisitaVeterinario Visitas{get;set;}
         public BuscarVisitaModel(IRepositorioVisitaVeterinario repositorio){
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
    }
}
