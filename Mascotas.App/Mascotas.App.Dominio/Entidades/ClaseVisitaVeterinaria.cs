using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("VisitaVeterinariaDb")]
    public class ClaseVisitaVeterinaria
    {
        ///[ForeignKey(nameof(Id))]
        [Key]
        [Required]
        [Column("idVisitaVeterinaria")]
        public long id { get;set; }
        [Required]
        [Column("fechaVisita")]
        [StringLength(10,MinimumLength=5)]
        public string fechaVisita { get; set;}
        [ForeignKey("IdEstadoMascota")]
        public ClaseEstadoMascota estadoMascota { get; set;}
        [Required]
        [Column("recomendaciones")]
        [StringLength(100,MinimumLength=5)]
        public string recomendaciones { get; set;}
        [Required]
        [Column("medicamentos")]
        [StringLength(100,MinimumLength=5)] 
        public string medicamentos { get;set; } 
        [ForeignKey("IdSolicitudVisita")] 
        public virtual ClaseSolicitudVisita solicitudVisita { get; set; }
        [NotMapped]
        public string Prueba { get; set;}


        public ClaseVisitaVeterinaria(){}
    }
}