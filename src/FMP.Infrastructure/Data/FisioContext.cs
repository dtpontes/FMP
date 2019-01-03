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
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<ProfissaoCliente> ProfissoesClientes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            #region Cliente

            modelBuilder.Entity<Cliente>()
                .HasMany(x => x.Contatos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasKey(x => x.ClienteId);

            modelBuilder.Entity<Cliente>().Property(x => x.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            #endregion

            #region Contato

            modelBuilder.Entity<Contato>()
                .HasOne<Cliente>()
                .WithMany(x => x.Contatos)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.ClienteId);


            modelBuilder.Entity<Contato>().Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(x => x.Telefone)
                .HasColumnType("varchar(15)");
            #endregion

            #region profissao
            modelBuilder.Entity<Profissao>().Property(x => x.Nome)
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Profissao>().Property(x => x.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            modelBuilder.Entity<Profissao>().Property(x => x.Descricao)
                .HasColumnType("varchar(1000)");

            #endregion

            #region endereco


            modelBuilder.Entity<Endereco>().Property(x => x.Bairro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(x => x.CEP)
                .HasColumnType("varchar(15)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(x => x.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(x => x.Referencia)
                .HasColumnType("varchar(200)");

            #endregion

            #region ProfissãoCliente

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(x => x.ProfissaoClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(x => x.Cliente)
                .WithMany(x => x.ProfissoesClientes)
                .HasForeignKey(x => x.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(x => x.Profissao)
                .WithMany(x => x.ProfissoesClientes)
                .HasForeignKey(x => x.ProfissaoId);


            #endregion

            #region Configurações Menu

            modelBuilder.Entity<Menu>()
                .HasMany(x => x.SubMenu)
                .WithOne()
                .HasForeignKey(x => x.MenuIdPai);

            #endregion


        }


    }
}
