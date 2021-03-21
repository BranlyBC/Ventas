using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BL.Rentas
{
    public class Contexto : DbContext
    {
        internal readonly object Facturas;

        public Contexto():base("VideoJuegos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



        public DbSet<Producto> Productos { get; set; }
    }
}