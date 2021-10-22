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
    public class BuscarAnimalModel : PageModel
    {
        private readonly IRepositorioMascota repositorio;
        public Mascota.App.Dominio.Entidades.Animal Animals;
        public BuscarAnimalModel(IRepositorioMascota repositorio){
            this.repositorio=repositorio;
        }
        public IActionResult OnGet(int Id)
        {
            Animals=repositorio.GetAnimals(Id);
            if(Animals==null){
                return RedirectToPage("./PaginaNoEncontrada");
            }
            else{
                return Page();
            }
        }
    }
}
