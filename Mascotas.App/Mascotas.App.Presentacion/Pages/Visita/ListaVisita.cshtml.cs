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
    public class ListaVisitaModel : PageModel
    {
        private readonly IRepositorioVisitaVeterinario repositorio;
        public IEnumerable<Mascota.App.Dominio.Entidades.VisitaVeterinario> Visitas = new List<Mascota.App.Dominio.Entidades.VisitaVeterinario>();
        public void OnGet()
        {
             Visitas=repositorio.GetAllVisitas();
        }
        public ListaVisitaModel(IRepositorioVisitaVeterinario repositorio){
            this.repositorio=repositorio;
        }
    }
}
