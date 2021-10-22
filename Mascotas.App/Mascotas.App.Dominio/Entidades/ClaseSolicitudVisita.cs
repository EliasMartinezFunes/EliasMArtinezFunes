using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("SolicitudVisitaDb")]
    public class ClaseSolicitudVisita
    {
        [Key]
        [Column("IdSolicitudVisita")]
        public long id { get; set;}
        [ForeignKey("IdMascota")]
        public ClaseMascota mascotas { get; set;}
        [ForeignKey("identificacion")]
        public virtual ClaseMedicoVeterinario medicoVeterinario { get; set; }
        [ForeignKey("idMascota")]
        public ClaseTipoAnimal tipoAnimal { get; set; }
        [ForeignKey("identificacion")]
        public ClaseDuenoMascota duenoMascota {get; set;}

    }
}