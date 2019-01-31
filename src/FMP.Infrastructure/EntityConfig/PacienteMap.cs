using System;
using System.Collections.Generic;
using System.Text;
using FMP.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FMP.Infrastructure.EntityConfig
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {

            builder.HasKey(x => x.PacienteId);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasColumnType("varchar(255)");

            builder.Property(x => x.Complemento)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.CEP)
                .HasColumnType("varchar(15)");

            builder.Property(x => x.TelCelular)
                .HasColumnType("varchar(15)");

            builder.Property(x => x.TelResidencial)
                .HasColumnType("varchar(15)");

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)");

            builder.Property(x => x.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Creditos)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.RG)
                .HasColumnType("varchar(20)");

            builder.Property(x => x.DataNascimento)
                .HasColumnType("datetime");


            builder.HasMany(x => x.PacienteCreditos)
                .WithOne(x => x.Paciente)
                .HasForeignKey(x => x.PacienteId)
                .HasPrincipalKey(x => x.PacienteId);

            builder.HasMany(x => x.PacienteDebitos)
                .WithOne(x => x.Paciente)
                .HasForeignKey(x => x.PacienteId)
                .HasPrincipalKey(x => x.PacienteId);
            
        }
    }
}
