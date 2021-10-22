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
    public class IngresarAnimalModel : PageModel
    {
         [BindProperty]
        public Mascota.App.Dominio.Entidades.Animal Animals{get;set;}
        private readonly IRepositorioMascota repositorio;
        public void OnGet()
        {
        }
        public IngresarAnimalModel(IRepositorioMascota repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            Animals=repositorio.AddAnimals(Animals);
        }
    }
}
