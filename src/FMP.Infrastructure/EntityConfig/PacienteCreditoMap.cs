using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class PacienteCreditoMap : IEntityTypeConfiguration<PacienteCredito>
    {
        public void Configure(EntityTypeBuilder<PacienteCredito> builder)
        {
            builder.HasKey(x => x.PacienteCreditoId);

            builder.Property(x => x.Valor)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(x => x.Compensado)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(x => x.QtdCreditos)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Data)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne<Paciente>()
               .WithMany(x => x.PacienteCreditos)
               .HasForeignKey(x => x.PacienteId)
               .HasPrincipalKey(x => x.PacienteId);
        }
    }
}
