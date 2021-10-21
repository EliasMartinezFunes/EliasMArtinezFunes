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
    public class IngresarEspecializacionModel : PageModel
    {
        [BindProperty]
        public Mascota.App.Dominio.Entidades.Especializacion Especializaciones{get;set;}

        private readonly IRepositorioEspecializacion repositorio;
        public void OnGet()
        {
        }
        public IngresarEspecializacionModel(IRepositorioEspecializacion repositorio){
            this.repositorio=repositorio;
        }
        public void OnPost(){
            
            
            Especializaciones=repositorio.AddEspecializaciones(Especializaciones);
 
        }
    }   
}
