using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamoxApiEntities
{
    public class FamoxApiContext: DbContext
    {
        public DbSet<Accesorio> Accesorios { get; set; }
        public DbSet<EquipoDigital> EquiposDigitales { get; set; }
        public DbSet<Gasoterapia> Gasoterapias { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<UnidadDeSuministro> UnidadesDeSuministros { get; set; }
        public DbSet<ModeloAccesorio> ModelosAccesorios { get; set; }
        public DbSet<ModeloEquipoDigital> ModelosEquiposDigitales { get; set; }
        public DbSet<ModeloGasoterapia> ModelosGasoterapia { get; set; }
        public DbSet<Rango> Rangos { get; set; }
        public DbSet<Conector> Conectores { get; set; }
        public DbSet<Iluminacion> Iluminaciones { get; set; }
        public DbSet<MediaTension> MediaTensiones { get; set; }
        public DbSet<BajaTension> BajaTensiones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-5KNKCP2\SQLEXPRESS;Database=Famox;Trusted_Connection=True;TrustServerCertificate=Yes;");
        }
    }
}
