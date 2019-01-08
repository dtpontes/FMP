using System;
using System.Collections.Generic;
using System.Text;
using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FMP.Infrastructure.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {

            builder.HasOne<Cliente>()
                .WithMany(x => x.Contatos)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.ClienteId);


            builder.Property(x => x.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(15)");
        }
    }
}
