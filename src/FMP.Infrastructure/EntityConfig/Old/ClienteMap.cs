using System;
using System.Collections.Generic;
using System.Text;
using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FMP.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasMany(x => x.Contatos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.ClienteId);

            builder.HasKey(x => x.ClienteId);

            builder.Property(x => x.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
