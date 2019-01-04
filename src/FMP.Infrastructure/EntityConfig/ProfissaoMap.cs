using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CBO)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(1000)");
        }
    }
}
