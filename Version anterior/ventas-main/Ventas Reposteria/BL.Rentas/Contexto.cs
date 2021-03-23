using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
     public class Contexto: DbContext
    {
        public Contexto(): base("VideoJuegos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          //  Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

    }
}
