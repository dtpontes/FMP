using System.Security.Cryptography.X509Certificates;
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
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            modelBuilder.Entity<Cliente>().Property(x => x.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(x => x.Telefone)
                .HasColumnType("varchar(15)");
        }

        
    }
}
