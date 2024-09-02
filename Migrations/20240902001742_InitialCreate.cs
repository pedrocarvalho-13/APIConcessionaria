using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIConcessionaria.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstoqueDeCarros",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    Fabricante = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Ano = table.Column<int>(type: "integer", nullable: false),
                    Quilometragem = table.Column<double>(type: "double precision", nullable: false),
                    Situacao = table.Column<int>(type: "integer", nullable: false),
                    Fipe = table.Column<double>(type: "double precision", nullable: false),
                    ValorComprado = table.Column<double>(type: "double precision", nullable: false),
                    ValorVenda = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueDeCarros", x => x.Placa);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstoqueDeCarros");
        }
    }
}
