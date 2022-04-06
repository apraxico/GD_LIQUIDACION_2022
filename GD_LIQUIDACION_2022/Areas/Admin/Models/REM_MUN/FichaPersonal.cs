using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN
{
    [Table("FichaPersonal")]
    public class FichaPersonal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Id_Funcionario { get; set; }

        [StringLength(20)]
        public string Nacionalidad { get; set; }

        [StringLength(30)]
        public string Lugar_Nacimiento { get; set; }

        [StringLength(10)]
        public string Num_Reg_Electoral { get; set; }

        [StringLength(30)]
        public string Circunscripcion { get; set; }

        [StringLength(20)]
        public string Inscripcion_Militar { get; set; }

        public DateTime? Fecha_Militar { get; set; }

        public short? Situacion_Militar { get; set; }

        [StringLength(20)]
        public string Canton_Militar { get; set; }

        public short? Estudios { get; set; }

        public short? Estado_Estudios { get; set; }

        [StringLength(200)]
        public string Titulo { get; set; }

        public DateTime? Fecha_Titulo { get; set; }

        [StringLength(25)]
        public string Centro_Estudio { get; set; }

        [StringLength(30)]
        public string Lugar_Trabajo { get; set; }

        [StringLength(30)]
        public string Cargo { get; set; }

        public short? Id_Jefe_Directo { get; set; }

        [StringLength(80)]
        public string Jefe_Directo { get; set; }

        public DateTime? Fecha_Cargo { get; set; }

        [StringLength(10)]
        public string Num_Tarjeta { get; set; }

        [StringLength(20)]
        public string Compañia_Seguro { get; set; }

        [StringLength(10)]
        public string Poliza_Seguro { get; set; }

        public DateTime? Fecha_Publica { get; set; }

        public DateTime? Fecha_Municipal { get; set; }

        public short? Reconoce_Años { get; set; }

        [StringLength(20)]
        public string Compañia_Seguro1 { get; set; }

        [StringLength(10)]
        public string Poliza_Seguro1 { get; set; }

        public short? ReconoceAnoPrivada { get; set; }

        public short? ReconoceMesPrivada { get; set; }

        public short? ReconoceDiaPrivada { get; set; }

        public short? ReconoceAnoPublica { get; set; }

        public short? ReconoceMesPublica { get; set; }

        public int? ReconoceDiaPublica { get; set; }

        [StringLength(80)]
        public string Conyuge { get; set; }

        public short? Calidad_Cargo { get; set; }

        public short? Requisito_Especifico { get; set; }

        [StringLength(50)]
        public string Cargo_Confianza { get; set; }

        public DateTime? Fec_AntGrado { get; set; }

        public DateTime? Fec_AntGradoII { get; set; }

        [StringLength(1000)]
        public string DetalleCdelTrabajo { get; set; }

        public short? Adscrito { get; set; }

        public int? Id_CargoFuncionario { get; set; }

        public int? Dias_Permisos { get; set; }

        public short? ConSindicato { get; set; }

        public int? DiasPermisoAdm { get; set; }

        public short? Id_PlantaMunicipal { get; set; }

        public short? Profesional { get; set; }

        public short? Codigo_Etnia { get; set; }

        public short? Codigo_Discapacidad { get; set; }
    }
}