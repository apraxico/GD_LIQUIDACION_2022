using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN_PAE
{
    [Table("FichaFuncionario")]
    public class FichaFuncionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id_Funcionario { get; set; }

        public short? Id_Area { get; set; }

        public short? Activo { get; set; }

        [StringLength(10)]
        public string Rut { get; set; }

        [StringLength(40)]
        public string Apellidos { get; set; }

        [StringLength(40)]
        public string Nombres { get; set; }

        public short? Sexo { get; set; }

        public short? EstadoCivil { get; set; }

        public DateTime? Fec_Nacimiento { get; set; }

        [StringLength(40)]
        public string Direccion { get; set; }

        public short? Id_Comuna { get; set; }

        [StringLength(25)]
        public string Telefonos { get; set; }

        [StringLength(20)]
        public string CodigoPostal { get; set; }

        public DateTime? Fec_InicioContrato { get; set; }

        public DateTime? Fec_FinalContrato { get; set; }

        public short? Reg_Previsional { get; set; }

        public short? CotizaDesahucio { get; set; }

        public short? Id_Afp { get; set; }

        public float? RebajaAfp { get; set; }

        public DateTime? Fec_Afp { get; set; }

        public short? Id_Isapre { get; set; }

        public short? ModoPactado { get; set; }

        public float? MontoPactado { get; set; }

        public DateTime? Fec_Isapre { get; set; }

        public short? AdicionalDosSiNo { get; set; }

        public float? AdicionalPorcentaje { get; set; }

        public DateTime? Fec_ContratoIsapre { get; set; }

        public short? TipoLiquidacion { get; set; }

        public short? AfectoZona { get; set; }

        public int? RentaPromedio { get; set; }

        public short? CalDosPorAdiSiNo { get; set; }

        public short? JubiladoSiNo { get; set; }

        public short? TopeImponibilidadSiNo { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public short? ModoPactadoAuge { get; set; }

        public float? MontoAuge { get; set; }

        public short? grupo { get; set; }

        public float? MontoPactado_Pesos { get; set; }

        public short? Estado_Previsional { get; set; }

        [StringLength(25)]
        public string Nro_FunAfp { get; set; }

        [StringLength(25)]
        public string Nro_FunIsapre { get; set; }

        [StringLength(50)]
        public string FonoMovil { get; set; }

        [StringLength(20)]
        public string Apellido_Paterno { get; set; }

        [StringLength(20)]
        public string Apellido_Materno { get; set; }
    }
}