using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("MedicoVeterinarioDb")]
    public class ClaseMedicoVeterinario:ClasePersona
    {
        
        public long tarjetaProfesional { get; set; }
        [ForeignKey("idMascota")]
        public ClaseTipoAnimal tipoAnimal { get; set; }

        public ClaseMedicoVeterinario(){}
    }
}