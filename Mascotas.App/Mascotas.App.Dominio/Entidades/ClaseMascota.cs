using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("MascotaDb")]
    public class ClaseMascota
    {
        [Key]
        [Column("IdMascota")]
        public long id { get;set; }
        [Required]
        [Column("NombreMascota")]
        [StringLength(50,MinimumLength=5)]
        public string nombre { get; set;}
        [Required]
        [Column("ColorDeOjosMascota")]
        [StringLength(10,MinimumLength=5)]
        public string colorDeOjos { get;set; }
        [Required]
        [Column("ColorDePielMascota")]
        [StringLength(10,MinimumLength=5)]
        public string colorDePiel { get;set; }
        [Required]
        [Column("EstaturaMascota")]
        [StringLength(10,MinimumLength=3)]
        public float Estatura{get; set;}
        [Required]
        [Column("RazaMascota")]
        [StringLength(10,MinimumLength=3)]
        public string raza { get; set;} 
        [ForeignKey("ClaseTipoAnimal")]
        public ClaseTipoAnimal tipoAnimal { get; set;} 

        public ClaseMascota(){}  
    }
}