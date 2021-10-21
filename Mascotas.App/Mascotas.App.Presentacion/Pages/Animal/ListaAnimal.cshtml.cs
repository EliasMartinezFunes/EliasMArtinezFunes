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
    public class ListaAnimalModel : PageModel
    {
        private readonly IRepositorioMascota repositorio;
         public IEnumerable<Mascota.App.Dominio.Entidades.Animal> Animals = new List<Mascota.App.Dominio.Entidades.Animal>();
       
        public void OnGet()
        {
            Animals=repositorio.GetAllAnimals();
        }
        public ListaAnimalModel(IRepositorioMascota repositorio){
            this.repositorio=repositorio;
        }
    }
}
