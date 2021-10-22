using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("estadoMascotaDb")]
    public class ClaseEstadoMascota
    {
        ///[ForeignKey(nameof(Id))]
        [Key]
        [Column("IdEstadoMascota")]
        public long id {get; set;}
         [Required]
        [Column("TemperaturaMascota")]
        [StringLength(10,MinimumLength=2)]
        public string temperatura { get;set; }
        [Required]
        [Column("PesoMascota")]
        [StringLength(10,MinimumLength=2)]
        public string peso { get;set; }
        [Required]
        [Column("FrecuenciaRepiratoriaMascota")]
        [StringLength(10,MinimumLength=2)]
        public string frecuenciaRespiratoria { get;set; }
        [Required]
        [Column("FrecuenciaCardiacaMascota")]
        [StringLength(10,MinimumLength=2)]
        public string frecuenciaCardiaca { get;set; }
        [Required]
        [Column("EstadoAnimoMascota")]
        [StringLength(20,MinimumLength=5)]
        public string estadoDeAnimo { get;set; }

        //Constructor
        public ClaseEstadoMascota(){}
    }
}