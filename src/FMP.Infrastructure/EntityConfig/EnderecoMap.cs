using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.CEP)
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder.Property(x => x.Logradouro)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Referencia)
                .HasColumnType("varchar(200)");
        }
    }
}
