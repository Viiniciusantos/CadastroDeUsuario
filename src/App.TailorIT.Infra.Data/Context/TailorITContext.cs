using App.TailorIT.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace App.TailorIT.Infra.Data.Context
{
    public class TailorITContext : DbContext
    {
        public TailorITContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TailorITContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
