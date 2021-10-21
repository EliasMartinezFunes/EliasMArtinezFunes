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
    public class ActualizarAnimalModel : PageModel
    {
        private readonly IRepositorioMascota repositorio;
        public Animal Animals{get;set;}
        public ActualizarAnimalModel(IRepositorioMascota repositorio){
            this.repositorio=repositorio;
        }
        public IActionResult OnGet(int Id)
        {
            Animals=repositorio.GetAnimals(Id);
            if (Animals==null){
                return RedirectToPage("./PaginaNoEncontrada"); 
            }
            else {
                return Page();
            }
        }
        public IActionResult OnPost(Animal Animals)

        {
          if (!ModelState.IsValid){
              return Page();
          }
          if(Animals.Id>0){
            repositorio.UpdateAnimals(Animals);
          }
            return RedirectToPage("./ListaAnimal");
          
        }
    }
}
