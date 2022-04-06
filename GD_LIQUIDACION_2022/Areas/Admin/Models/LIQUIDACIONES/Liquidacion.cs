using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.LIQUIDACIONES
{
    public class Liquidacion
    {
        public string RUT { get; set; }
        public string IDFuncionario { get; set; }
        public string MesProceso { get; set; }
        public string AñoProceso { get; set; }
        public int TipoProceso { get; set; }
        public bool EsPMG { get; set; }
        public string IDProcesoPMG { get; set; }
    }
}