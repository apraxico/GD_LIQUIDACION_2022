using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN
{
    [Table("FichaMunicipal")]
    public class FichaMunicipal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id_Funcionario { get; set; }

        public short? TipoRemuneracion { get; set; }

        public short? TipoCargo { get; set; }

        public short? TipoCalidad { get; set; }

        public short? TipoEmpleado { get; set; }

        public short? Id_Planta { get; set; }

        public short? Id_Grado { get; set; }

        public short? Id_Incremento { get; set; }

        public short? Tiene_Ley18675a11 { get; set; }

        public int? Id_Direccion { get; set; }

        public int? Id_Departamento { get; set; }

        public int? Id_Seccion { get; set; }

        public DateTime? Fec_InicioBienios { get; set; }

        public short? NroBienios { get; set; }

        public short? NroBieniosZona { get; set; }

        public short? Jornada { get; set; }

        public short? Trienios { get; set; }

        public short? Id_SueldoMedico { get; set; }

        public int? SueldoCodTrabajo { get; set; }

        public short? GradoSubrogante { get; set; }

        public DateTime? Fecha_Titulacion { get; set; }

        public short? Percajasino { get; set; }

        public short? Movilizasino { get; set; }

        public short? Pasajesino { get; set; }

        public short? CodigoTrabajo { get; set; }

        [StringLength(255)]
        public string DetalleCdelTrabajo { get; set; }

        [StringLength(10)]
        public string CentroCosto { get; set; }

        public short? Pagador { get; set; }

        public short? Id_Proyecto { get; set; }

        public short? TipoHonorario { get; set; }

        public int? NroDecretoHono { get; set; }

        public short? DctoMutualHono { get; set; }

        public short? DctoPrevisHono { get; set; }

        public int? CentroNuevo { get; set; }

        public int? CentroAntiguo { get; set; }

        public int? Num_Decreto { get; set; }

        public DateTime? Fec_Decreto { get; set; }

        public int? Id_Oficina { get; set; }

        public short? Afiliado_CCAF { get; set; }

        public short? AporteLey20305 { get; set; }

        public int? Concejal { get; set; }

        public short? Id_Clasificacion_INE { get; set; }
    }
}