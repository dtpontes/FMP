using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(x => x.CidadeId);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasOne<Estado>()
               .WithMany(x => x.Cidades)
               .HasForeignKey(x => x.EstadoId)
               .HasPrincipalKey(x => x.EstadoId);

        }
    }
}
