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
    public class IngresarPersonaModel : PageModel
    {
        [BindProperty]
        public Mascota.App.Dominio.Entidades.Persona personas{get;set;}

        private readonly IRepositorioPersona repositorio;
        public void OnGet()
        {
        }
        public IngresarPersonaModel(IRepositorioPersona repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            
            
            personas=repositorio.AddPersona(personas);
 
        }
    }
}
