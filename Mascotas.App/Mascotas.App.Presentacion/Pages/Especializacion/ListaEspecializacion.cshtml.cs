using System;
using Mascota.App.Persistencia.AppRepositorios;
using Mascota.App.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mascotas.App.Presentacion.Pages
{
    public class ListaEspecializacionModel : PageModel
    {
        private readonly IRepositorioEspecializacion repositorio;
        public IEnumerable<Mascota.App.Dominio.Entidades.Especializacion> Especializaciones = new List<Mascota.App.Dominio.Entidades.Especializacion>();

        public void OnGet()
        {
            Especializaciones=repositorio.GetAllEspecializaciones();
        }
        public ListaEspecializacionModel(IRepositorioEspecializacion repositorio){
            this.repositorio=repositorio;
        }
    }
}
