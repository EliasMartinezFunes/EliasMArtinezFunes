using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mascotas.App.Dominio.Entidades
{
    [Table("EmpresaDb")] 
    public class ClaseEmpresa
    {
        ///[ForeignKey(nameof(Nit))]

        /// 
        //public int Id { get; set;}
         
        [Column("Nit")]
        [Key]
        public long nit { get; set;}
        [Required]
        [Column("RazonSocial")]
        [StringLength(50,MinimumLength=5)]
        public string razonSocial {get;set;} 
        [Required]
        [Column("DirecionEmpresa")]
        [StringLength(30,MinimumLength=5)]      
        public string direccion { get; set; }
        [ForeignKey("identificacion")]
        public virtual ClaseMedicoVeterinario medicoVeterinario { get; set; }

        //Constructor
        public ClaseEmpresa(){}
    }
}