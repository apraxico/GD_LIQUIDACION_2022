using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN
{
    public class REM_MUN : DbContext
    {
        public REM_MUN()
        {
        }

        public virtual DbSet<FichaFuncionario> FichaFuncionarios { get; set; }
        public virtual DbSet<FichaHonorario> FichaHonorarios { get; set; }
        public virtual DbSet<FichaMunicipal> FichaMunicipals { get; set; }
        public virtual DbSet<FichaPersonal> FichaPersonals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FichaFuncionario>()
           .Property(e => e.Rut)
           .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Apellidos)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Nombres)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Direccion)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Telefonos)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.CodigoPostal)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Email)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Nro_FunAfp)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Nro_FunIsapre)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.FonoMovil)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Apellido_Paterno)
            .IsUnicode(false);

            modelBuilder.Entity<FichaFuncionario>()
            .Property(e => e.Apellido_Materno)
            .IsUnicode(false);

            modelBuilder.Entity<FichaMunicipal>()
            .Property(e => e.DetalleCdelTrabajo)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Nacionalidad)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Lugar_Nacimiento)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Num_Reg_Electoral)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Circunscripcion)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Inscripcion_Militar)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Canton_Militar)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Titulo)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Centro_Estudio)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Lugar_Trabajo)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Cargo)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Jefe_Directo)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Num_Tarjeta)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Compañia_Seguro)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Poliza_Seguro)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Compañia_Seguro1)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Poliza_Seguro1)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Conyuge)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.Cargo_Confianza)
            .IsUnicode(false);

            modelBuilder.Entity<FichaPersonal>()
            .Property(e => e.DetalleCdelTrabajo)
            .IsUnicode(false);
        }
    }
}