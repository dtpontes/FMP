using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace FMP.Infrastructure.Data
{
    public class FisioContext : DbContext
    {
        public FisioContext(DbContextOptions<FisioContext> options) :base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
        }

        
    }
}
