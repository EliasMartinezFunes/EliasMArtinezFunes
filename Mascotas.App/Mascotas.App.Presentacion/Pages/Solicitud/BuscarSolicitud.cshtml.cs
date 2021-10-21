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
    public class BuscarSolicitudModel : PageModel
    {
    private readonly IRepositorioSolicitudVisita repositorio;
         public Mascota.App.Dominio.Entidades.SolicitudVisita Solicitud{get;set;}
         public BuscarSolicitudModel(IRepositorioSolicitudVisita repositorio){
             this.repositorio=repositorio;
             }
        public IActionResult OnGet(int Id)
        {
            Solicitud=repositorio.GetSolicitud(Id);
            if (Solicitud==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }

        }
    }
}
