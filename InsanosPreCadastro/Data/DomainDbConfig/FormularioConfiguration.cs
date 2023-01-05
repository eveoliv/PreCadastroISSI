using InsanosPreCadastro.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InsanosPreCadastro.Data.DomainDbConfig
{
    public class FormularioConfiguration : IEntityTypeConfiguration<Integrante>
    {
        public void Configure(EntityTypeBuilder<Integrante> builder)
        {
            builder.ToTable("Cadastro");
            builder.Property(p => p.Id).HasColumnName("Id").HasColumnType("integer");

            builder.Property(f => f.UF).HasColumnName("uf").HasColumnType("nvarchar(2)").IsRequired();
            builder.Property(f => f.RG).HasColumnName("rg").HasColumnType("nvarchar(15)").IsRequired();            
            builder.Property(f => f.CPF).HasColumnName("cpf").HasColumnType("nvarchar(11)").IsRequired();
            builder.Property(f => f.CEP).HasColumnName("cep").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(f => f.Mail).HasColumnName("mail").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.Numero).HasColumnName("numero").HasColumnType("nvarchar(4)").IsRequired();
            builder.Property(f => f.Bairro).HasColumnName("bairro").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.Cidade).HasColumnName("cidade").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.TelefoneFixo).HasColumnName("telefone_fixo").HasColumnType("nvarchar(15)");
            builder.Property(f => f.Divisao).HasColumnName("divisao").HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(f => f.Endereco).HasColumnName("endereco").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.Profissao).HasColumnName("profissao").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(f => f.NomeColete).HasColumnName("nome_colete").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.Complemento).HasColumnName("complemento").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.NomeCompleto).HasColumnName("nome_completo").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(f => f.TamanhoColete).HasColumnName("tamanho_colete").HasColumnType("nvarchar(3)").IsRequired();
            builder.Property(f => f.MaterialColete).HasColumnName("material_colete").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(f => f.TamanhoCamiseta).HasColumnName("tamanho_camiseta").HasColumnType("nvarchar(3)").IsRequired();
            builder.Property(f => f.TelefoneCelular).HasColumnName("telefone_celular").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(f => f.FormaPagamentoColete).HasColumnName("forma_pagamento_colete").HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(f => f.NomeContatoEmergencia).HasColumnName("nome_contato_emergencia").HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(f => f.TelefoneContatoEmergencia).HasColumnName("telefone_contato_emergencia").HasColumnType("nvarchar(15)").IsRequired();

            builder.Property(f => f.DataEnvio).HasColumnName("data_envio").HasColumnType("datetime").IsRequired();
            builder.Property(f => f.DataNascimento).HasColumnName("data_nascimento").HasColumnType("datetime").IsRequired();
        }
    }
    
}
