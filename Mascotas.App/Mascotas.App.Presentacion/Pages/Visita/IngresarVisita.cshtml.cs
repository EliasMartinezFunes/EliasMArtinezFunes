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
    public class IngresarVisitaModel : PageModel
    {
        [BindProperty]
        public Mascota.App.Dominio.Entidades.VisitaVeterinario Visitas{get;set;}
        private readonly IRepositorioVisitaVeterinario repositorio;
        public void OnGet()
        {
        }
        public IngresarVisitaModel(IRepositorioVisitaVeterinario repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            Visitas=repositorio.AddVisitas(Visitas);
        }
    }
}
