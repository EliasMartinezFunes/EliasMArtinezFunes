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
    public class ListaVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorio;
        public IEnumerable<Mascota.App.Dominio.Entidades.Veterinario> Veterinario = new List<Mascota.App.Dominio.Entidades.Veterinario>();


        public void OnGet()
        {
            Veterinario=repositorio.GetAllVeterinario();
        }
        public ListaVeterinarioModel(IRepositorioVeterinario repositorio){
            this.repositorio=repositorio;
        }
    }
}
