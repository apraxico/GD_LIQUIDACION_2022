using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.REM_MUN_PAE
{
    public class REM_MUN_PAE : DbContext
    {
        public REM_MUN_PAE()
        {
        }

        public virtual DbSet<FichaFuncionario> FichaFuncionarios { get; set; }
        public virtual DbSet<HistoricoLiquidacion> HistoricoLiquidacions { get; set; }
        public virtual DbSet<PlanillaSuplementaria> PlanillaSuplementarias { get; set; }
        public virtual DbSet<Liquidacion> Liquidacions { get; set; }

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
        }
    }
}