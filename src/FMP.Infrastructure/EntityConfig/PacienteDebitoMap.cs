using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMP.Infrastructure.EntityConfig
{
    public class PacienteDebitoMap : IEntityTypeConfiguration<PacienteDebito>
    {
        public void Configure(EntityTypeBuilder<PacienteDebito> builder)
        {
            builder.HasKey(x => x.PacienteDebitoId);

            builder.Property(x => x.QtdCreditos)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Data)
                .HasColumnType("datetime")
                .IsRequired();            

            builder.HasOne<Paciente>()
               .WithMany(x => x.PacienteDebitos)
               .HasForeignKey(x => x.PacienteId)
               .HasPrincipalKey(x => x.PacienteId);

        }
    }
}
