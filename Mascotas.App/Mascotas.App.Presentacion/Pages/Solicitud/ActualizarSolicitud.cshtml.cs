using System;
using System.Collections.Generic;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.App.Presentacion.Pages
{
    public class ActualizarSolicitudModel : PageModel
    {
          private readonly IRepositorioSolicitudVisita repositorio;
        public SolicitudVisita Solicitud{get;set;}
        public ActualizarSolicitudModel(IRepositorioSolicitudVisita repositorio){
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
        public IActionResult OnPost(SolicitudVisita Solicitud)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(Solicitud.Id>0){
            repositorio.UpdateSolicitud(Solicitud);
          }
            return RedirectToPage("./ListaSolicitud");
          
        }
    }
}
