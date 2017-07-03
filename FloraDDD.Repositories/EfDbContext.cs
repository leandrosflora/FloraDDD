//using System.Data.Entity;
//using System.Data.Entity.ModelConfiguration.Conventions;
using FloraDDD.Domain.Entities;
//using FloraDDD.Repositories.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FloraDDD.Repositories
{
    public partial class EfDbContext : DbContext
    {
        //public EfDbContext()
        //    : base("EfDbContext")
        //{
        //    Configuration.LazyLoadingEnabled = false;
        //}

        public EfDbContext(DbContextOptions<EfDbContext> options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

         

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasColumnType("varchar"));

            //modelBuilder.Properties<string>()
            //    .Configure(p => p.HasMaxLength(50));

            //modelBuilder.Configurations.Add(new UsuarioConfigurations());
        }
    }
}
