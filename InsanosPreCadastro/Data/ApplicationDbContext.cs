using InsanosPreCadastro.Domain;
using Microsoft.EntityFrameworkCore;
using InsanosPreCadastro.Data.DomainDbConfig;

namespace InsanosPreCadastro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Formulario> Formulario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FormularioConfiguration());
        }
    }
}
