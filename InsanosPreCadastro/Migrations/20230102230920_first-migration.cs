using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InsanosPreCadastro.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    divisao = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    nome_colete = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    nome_completo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    rg = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    numero = table.Column<string>(type: "nvarchar(4)", nullable: false),
                    complemento = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    bairro = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    uf = table.Column<string>(type: "nvarchar(2)", nullable: false),
                    cep = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    telefone_celular = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    telefone_fixo = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    nome_contato_emergencia = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    telefone_contato_emergencia = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    profissao = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    tamanho_camiseta = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    tamanho_colete = table.Column<string>(type: "nvarchar(3)", nullable: false),
                    material_colete = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    forma_pagamento_colete = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    data_envio = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
