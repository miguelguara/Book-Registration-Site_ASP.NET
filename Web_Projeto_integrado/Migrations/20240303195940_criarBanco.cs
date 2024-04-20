using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_Projeto_integrado.Migrations
{
    /// <inheritdoc />
    public partial class criarBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emprestimos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recebedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fornecedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LivroEmprestado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dataultimaatualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emprestimos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emprestimos");
        }
    }
}
