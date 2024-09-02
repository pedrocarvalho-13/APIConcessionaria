using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIConcessionaria.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSituacaoToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Situacao",
                table: "EstoqueDeCarros",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Situacao",
                table: "EstoqueDeCarros",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);
        }
    }
}
