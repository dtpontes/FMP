﻿// <auto-generated />
using System;
using FMP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FMP.Infrastructure.Migrations
{
    [DbContext(typeof(FisioContext))]
    [Migration("20190203004359_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Cidade", b =>
                {
                    b.Property<int>("CidadeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("EstadoId");

                    b.HasKey("CidadeId");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Estado", b =>
                {
                    b.Property<int>("EstadoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("EstadoId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP");

                    b.Property<string>("CPF");

                    b.Property<int>("CidadeId");

                    b.Property<string>("Complemento");

                    b.Property<int>("Creditos");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Foto");

                    b.Property<string>("Nome");

                    b.Property<string>("RG");

                    b.Property<string>("TelCelular");

                    b.Property<string>("TelResidencial");

                    b.HasKey("PacienteId");

                    b.HasIndex("CidadeId");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.PacienteCredito", b =>
                {
                    b.Property<int>("PacienteCreditoId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Compensado");

                    b.Property<DateTime>("Data");

                    b.Property<int>("IdTipoPagamento");

                    b.Property<int>("PacienteId");

                    b.Property<int>("QtdCreditos");

                    b.Property<int?>("TipoPagamentoId");

                    b.Property<decimal>("Valor");

                    b.HasKey("PacienteCreditoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("PacienteCredito");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.PacienteDebito", b =>
                {
                    b.Property<int>("PacienteDebitoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("PacienteId");

                    b.Property<int>("QtdCreditos");

                    b.HasKey("PacienteDebitoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("PacienteDebito");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.TipoPagamento", b =>
                {
                    b.Property<int>("TipoPagamentoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("TipoPagamentoId");

                    b.ToTable("TipoPagamento");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Cidade", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Paciente", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.PacienteCredito", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Paciente", "Paciente")
                        .WithMany("PacienteCreditos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FMP.ApplicationCore.Entities.TipoPagamento", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoId");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.PacienteDebito", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Paciente", "Paciente")
                        .WithMany("PacienteDebitos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
