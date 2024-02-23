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
        // Todos los Objetos: Gasoterapia - Obra - Accesorio - Unid Suministro - Equipos Digitales
        public DbSet<Accesorio> Accesorios { get; set; }
        public DbSet<EquipoDigital> EquiposDigitales { get; set; }
        public DbSet<Gasoterapia> Gasoterapias { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<UnidadDeSuministro> UnidadesDeSuministros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Famox;Trusted_Connection=True;TrustServerCertificate=Yes;");
        }
    }
}
