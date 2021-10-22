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
    public class PersonasModel : PageModel
    {
        //Variable de tipo interface
        private readonly IRepositorioPersona repositorio;
        //Variable que contiene Asignacion buscar persona
        public IEnumerable<Mascota.App.Dominio.Entidades.Persona> personas = new List<Mascota.App.Dominio.Entidades.Persona>();
       
        // Metodo de inicializacion de la pagina
        public void OnGet()
        {
            //Lista creada
           personas=repositorio.GetAllPersona();
        }
        public PersonasModel(IRepositorioPersona repositorio){
            this.repositorio=repositorio;
        }
    }
}
