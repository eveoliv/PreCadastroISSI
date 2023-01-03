﻿// <auto-generated />
using System;
using InsanosPreCadastro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InsanosPreCadastro.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230102230920_first-migration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("InsanosPreCadastro.Domain.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("cep");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("cpf");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("complemento");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime")
                        .HasColumnName("data_envio");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime")
                        .HasColumnName("data_nascimento");

                    b.Property<string>("Divisao")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("divisao");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("endereco");

                    b.Property<string>("FormaPagamentoColete")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("forma_pagamento_colete");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("mail");

                    b.Property<string>("MaterialColete")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("material_colete");

                    b.Property<string>("NomeColete")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome_colete");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("nome_completo");

                    b.Property<string>("NomeContatoEmergencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("nome_contato_emergencia");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("numero");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("profissao");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("rg");

                    b.Property<string>("TamanhoCamiseta")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("tamanho_camiseta");

                    b.Property<string>("TamanhoColete")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("tamanho_colete");

                    b.Property<string>("TelefoneCelular")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefone_celular");

                    b.Property<string>("TelefoneContatoEmergencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefone_contato_emergencia");

                    b.Property<string>("TelefoneFixo")
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("telefone_fixo");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasColumnName("uf");

                    b.HasKey("Id");

                    b.ToTable("Cadastro");
                });
#pragma warning restore 612, 618
        }
    }
}
