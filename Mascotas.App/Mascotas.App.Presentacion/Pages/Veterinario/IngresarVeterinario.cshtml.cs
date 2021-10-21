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
    public class IngresarVeterinarioModel : PageModel
    {
        [BindProperty]
        public Mascota.App.Dominio.Entidades.Veterinario Veterinario{get;set;}
        private readonly IRepositorioVeterinario repositorio;
        public void OnGet()
        {
        }
        public IngresarVeterinarioModel(IRepositorioVeterinario repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            Veterinario=repositorio.AddVeterinario(Veterinario);
        }
    }
}
