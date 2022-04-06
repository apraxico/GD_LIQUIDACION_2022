using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN_PAE
{
    [Table("HistoricoLiquidacion")]
    public class HistoricoLiquidacion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id_Funcionario { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Mes { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Ano { get; set; }

        public float? DiasTrabajados { get; set; }

        public int? SueldoBase { get; set; }

        public int? Incremento { get; set; }

        public int? AsigMunicipal { get; set; }

        public int? AsigLey18717 { get; set; }

        public int? AsigLey18566 { get; set; }

        public int? AsigLey18675A10 { get; set; }

        public int? AsigLey18675A11 { get; set; }

        public int? AsigLey19529 { get; set; }

        public int? AsigLey19429 { get; set; }

        public int? AsigZona { get; set; }

        public int? ComplementoZona { get; set; }

        public int? AsigBienios { get; set; }

        public int? AsigBieniosZona { get; set; }

        public int? ZonaBienios { get; set; }

        public int? CompZonaBienios { get; set; }

        public int? AsigTrienios { get; set; }

        public int? AsigEstimulo { get; set; }

        public int? AsigProfesional { get; set; }

        public int? AsigResponsabilidad { get; set; }

        public int? AsigDLey3551A39 { get; set; }

        public int? AsigLey19112_32A { get; set; }

        public int? AsigLey19112_20B { get; set; }

        public int? ImponibleDesahucio { get; set; }

        public short? NroHrsExtras25 { get; set; }

        public short? NroHrsExtras50 { get; set; }

        public int? MontoHrsExtras25 { get; set; }

        public int? MontoHrsExtras50 { get; set; }

        public int? IncrementoHrsExtras { get; set; }

        public int? TotalImponible { get; set; }

        public short? NroCargaNormal { get; set; }

        public short? NroCargaInvalida { get; set; }

        public short? NroCargaMaternal { get; set; }

        public int? MontoCarga { get; set; }

        public int? MontoCargaMater { get; set; }

        public int? MontoRetroactivo { get; set; }

        public int? MontoRetroMater { get; set; }

        public int? BaseImponible { get; set; }

        public int? MontoJubilacion { get; set; }

        public int? MontoDesahucio { get; set; }

        public int? MontoSalud { get; set; }

        public int? MontoAdicionalDos { get; set; }

        public int? MontoAdicionalFun { get; set; }

        public int? TotalTributable { get; set; }

        public int? BaseTributable { get; set; }

        public int? ImpuestoUnico { get; set; }

        public int? TotalOtrosHaberes { get; set; }

        public int? TotalHaberes { get; set; }

        public int? TotalOtrosDctos { get; set; }

        public int? TotalDctosLegales { get; set; }

        public int? TotalDctos { get; set; }

        public int? Liquido { get; set; }

        public short? MontoAdicionalLegal { get; set; }

        public int? MontoSaludLegal { get; set; }

        public int? BaseImponibleCesantia { get; set; }

        public int? MontoCesantia { get; set; }

        public int? MontoCesantiaEmpleador { get; set; }

        public int? MontoCtaAhorroAfp { get; set; }

        public int? MontoCotizVoluntaria { get; set; }

        public int? MontoAhorroPrevVoluntario { get; set; }

        public int? MontoDepositoConvenido { get; set; }

        public int? BaseImponibleIndemnizacion { get; set; }

        public int? MontoIndemnizacion { get; set; }

        public int? MontoTrabajoPesado { get; set; }

        public int? MontoTrabajoPesadoEmpleador { get; set; }

        public int? AportePatronal { get; set; }

        public int? Monto_SaludAuge { get; set; }

        public float? Porcentaje_Afp { get; set; }

        public int? MontoCCAF { get; set; }

        public int? MontoSinCCAF { get; set; }

        public int? MontoAporteLey20305 { get; set; }

        public short? Rebaja_CotVol { get; set; }

        public short? Rebaja_APVI { get; set; }

        public int? MontoPension { get; set; }

        public int? MontoSis { get; set; }

        public int? MontoSisEmpleador { get; set; }

        public int? MontoCotizAfiliadoVol { get; set; }

        public int? MontoAhorroAfiliadoVol { get; set; }

        public short? ModoPactadoReal { get; set; }

        public float? MontoPactadoReal { get; set; }

        public int? TopeDescuento { get; set; }

        public int? MontoAhorroPrevVoluntario2 { get; set; }

        public int? MontoAhorroPrevVoluntario3 { get; set; }

        public short? Rebaja_APVI2 { get; set; }

        public short? Rebaja_APVI3 { get; set; }
    }
}