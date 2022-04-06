using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GD_LIQUIDACION_2022.Areas.Admin.Models.INFORMES
{
    public partial class Informes : DbContext
    {
        public Informes()
        {
        }

        public virtual DbSet<LIQUIDACIONES_Informes_Registro> LIQUIDACIONES_Informes_Registro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}