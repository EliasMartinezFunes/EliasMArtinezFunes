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
    public class IngresarSolicitudModel : PageModel
    {
         [BindProperty]
        public Mascota.App.Dominio.Entidades.SolicitudVisita Solicitud{get;set;}
        private readonly IRepositorioSolicitudVisita repositorio;
        public void OnGet()
        {
        }
        public IngresarSolicitudModel(IRepositorioSolicitudVisita repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            Solicitud=repositorio.AddSolicitud(Solicitud);
        }
    }
}
