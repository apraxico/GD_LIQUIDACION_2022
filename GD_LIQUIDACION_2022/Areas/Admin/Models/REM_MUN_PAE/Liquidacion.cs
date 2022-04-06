using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN_PAE
{
    [Table("Liquidacion")]
    public class Liquidacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id_Funcionario { get; set; }
    }
}