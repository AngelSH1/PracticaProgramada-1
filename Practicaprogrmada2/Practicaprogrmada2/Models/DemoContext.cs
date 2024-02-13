using Microsoft.EntityFrameworkCore;

namespace Practicaprogrmada2.Models
{
    class DemoContext : DbContext
    {
        public DemoContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=;Database=Demo;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Usuario> usuario { get; set; }

    }
