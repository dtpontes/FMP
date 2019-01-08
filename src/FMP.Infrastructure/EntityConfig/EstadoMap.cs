using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(x => x.EstadoId);

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();
            
            builder.HasMany(x => x.Cidades)
                .WithOne(x => x.Estado)
                .HasForeignKey(x => x.EstadoId)
                .HasPrincipalKey(x => x.EstadoId);

        }
    }
}
