using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            builder.HasKey(x => x.ProfissaoClienteId);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.ProfissoesClientes)
                .HasForeignKey(x => x.ClienteId);

            builder.HasOne(x => x.Profissao)
                .WithMany(x => x.ProfissoesClientes)
                .HasForeignKey(x => x.ProfissaoId);
        }
    }
}
