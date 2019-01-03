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
    [Migration("20190103174950_CriarMenu")]
    partial class CriarMenu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Contato", b =>
                {
                    b.Property<int>("ContatoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int?>("ClienteId1");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(15)");

                    b.HasKey("ContatoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ClienteId1");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Referencia")
                        .HasColumnType("varchar(200)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MenuIdPai");

                    b.Property<string>("Titulo");

                    b.HasKey("MenuId");

                    b.HasIndex("MenuIdPai");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Profissao", b =>
                {
                    b.Property<int>("ProfissaoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CBO")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)");

                    b.HasKey("ProfissaoId");

                    b.ToTable("Profissao");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.ProfissaoCliente", b =>
                {
                    b.Property<int>("ProfissaoClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<int>("ProfissaoId");

                    b.HasKey("ProfissaoClienteId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProfissaoId");

                    b.ToTable("ProfissaoCliente");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Contato", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Cliente")
                        .WithMany("Contatos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FMP.ApplicationCore.Entities.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Endereco", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("FMP.ApplicationCore.Entities.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.Menu", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Menu")
                        .WithMany("SubMenu")
                        .HasForeignKey("MenuIdPai");
                });

            modelBuilder.Entity("FMP.ApplicationCore.Entities.ProfissaoCliente", b =>
                {
                    b.HasOne("FMP.ApplicationCore.Entities.Cliente", "Cliente")
                        .WithMany("ProfissoesClientes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FMP.ApplicationCore.Entities.Profissao", "Profissao")
                        .WithMany("ProfissoesClientes")
                        .HasForeignKey("ProfissaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}