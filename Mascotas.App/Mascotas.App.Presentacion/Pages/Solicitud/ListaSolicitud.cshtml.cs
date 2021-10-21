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
    public class ListaSolicitudModel : PageModel
    {
        private readonly IRepositorioSolicitudVisita repositorio;
        public IEnumerable<Mascota.App.Dominio.Entidades.SolicitudVisita> Solicitud = new List<Mascota.App.Dominio.Entidades.SolicitudVisita>();
        public void OnGet()
        {
             Solicitud=repositorio.GetAllSolicitud();
        }
        public ListaSolicitudModel(IRepositorioSolicitudVisita repositorio){
            this.repositorio=repositorio;
        }
    }
}
