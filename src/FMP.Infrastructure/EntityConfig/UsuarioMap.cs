using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.UsuarioId);

            builder.Property(x => x.Login)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

        }
    }
}
