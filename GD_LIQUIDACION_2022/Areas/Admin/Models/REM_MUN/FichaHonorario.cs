using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN
{
    public class FichaHonorario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id_Funcionario { get; set; }

        public short Beneficio_Viaticos { get; set; }

        public short Beneficio_Comision { get; set; }

        public short Beneficio_Horas_Extras { get; set; }

        public short Beneficio_Capacitacion { get; set; }

        public short Beneficio_LicenciaMedica { get; set; }

        public short Beneficio_PermisoAdministrativo { get; set; }

        public short Beneficio_FeriadoLegal { get; set; }
    }
}