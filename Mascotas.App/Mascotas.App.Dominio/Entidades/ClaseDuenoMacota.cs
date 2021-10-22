using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("DuenoMascotaDb")]
    public class ClaseDuenoMascota:ClasePersona
    {
        
        ///[Key]
        [Required]
        [Column("DirecionDueno")]
        [StringLength(30,MinimumLength=5)]
        public string direccion { get;set; }
        [ForeignKey("IdMascota")]
        public ClaseMascota mascotas { get; set;}

        //Constructor
        public ClaseDuenoMascota(){}
    }
}