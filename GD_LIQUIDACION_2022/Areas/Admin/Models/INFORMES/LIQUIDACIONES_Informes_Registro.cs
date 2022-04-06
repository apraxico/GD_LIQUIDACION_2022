using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.INFORMES
{
    public class LIQUIDACIONES_Informes_Registro
    {
        public int ID { get; set; }

        [Display(Name = "Fecha de registro")]
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Digitador { get; set; }

        [Display(Name = "Tipo de liquidación")]
        public int Tipo { get; set; }

        [Display(Name = "PMG")]
        public bool EsPmg { get; set; }

        public int Cantidad { get; set; }
    }
}