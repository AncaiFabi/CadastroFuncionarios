using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CadastroFuncionarios.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Cargo = table.Column<string>(type: "TEXT", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Cargo", "DataAdmissao", "DataDesligamento", "Nome" },
                values: new object[,]
                {
                    { 1, "Analista", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ana Souza" },
                    { 2, "Gerente", new DateTime(2019, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carlos Lima" },
                    { 3, "Assistente", new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda Dias" },
                    { 4, "Analista", new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "João Pedro" },
                    { 5, "Coordenadora", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luciana Braga" },
                    { 6, "Analista", new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marcos Silva" },
                    { 7, "Gerente", new DateTime(2017, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Juliana Rocha" },
                    { 8, "Assistente", new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rafael Costa" },
                    { 9, "Analista", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beatriz Martins" },
                    { 10, "Técnico", new DateTime(2016, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eduardo Nunes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionarios");
        }
    }
}
