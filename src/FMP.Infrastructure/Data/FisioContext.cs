using System.Security.Cryptography.X509Certificates;
using FMP.ApplicationCore.Entities;
using FMP.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace FMP.Infrastructure.Data
{
    public class FisioContext : DbContext
    {
        public FisioContext(DbContextOptions<FisioContext> options) :base(options)
        {

        }

        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Contato> Contatos { get; set; }
        //public DbSet<Endereco> Enderecos { get; set; }
        //public DbSet<Profissao> Profissoes { get; set; }
        //public DbSet<ProfissaoCliente> ProfissoesClientes { get; set; }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<PacienteCredito> PacienteCreditos { get; set; }
        public DbSet<PacienteDebito> PacienteDebitos { get; set; }
        public DbSet<TipoPagamento> TipoPagamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           

            modelBuilder.Entity<Cidade>().ToTable("Cidade");
            modelBuilder.Entity<Estado>().ToTable("Estado");
            modelBuilder.Entity<Paciente>().ToTable("Paciente");
            modelBuilder.Entity<PacienteCredito>().ToTable("PacienteCredito");
            modelBuilder.Entity<PacienteDebito>().ToTable("PacienteDebito");
            modelBuilder.Entity<TipoPagamento>().ToTable("TipoPagamento");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            



        }


    }
}
