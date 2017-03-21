using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class IdeaContext : DbContext
    {
        public IdeaContext() : base("IdeaContext")
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Campus> Campus { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
