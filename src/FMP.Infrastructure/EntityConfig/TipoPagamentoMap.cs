using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class TipoPagamentoMap : IEntityTypeConfiguration<TipoPagamento>
    {
        public void Configure(EntityTypeBuilder<TipoPagamento> builder)
        {
            builder.HasKey(x => x.TipoPagamentoId);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

        }
    }
}
