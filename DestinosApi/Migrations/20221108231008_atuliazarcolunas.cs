using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DestinosApi.Migrations
{
    public partial class atuliazarcolunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinos",
                table: "Destinos");

            migrationBuilder.RenameTable(
                name: "Destinos",
                newName: "destinos");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "destinos",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Uf",
                table: "destinos",
                newName: "uf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "destinos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "destinos",
                newName: "destino");

            migrationBuilder.AddPrimaryKey(
                name: "PK_destinos",
                table: "destinos",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_destinos",
                table: "destinos");

            migrationBuilder.RenameTable(
                name: "destinos",
                newName: "Destinos");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Destinos",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "uf",
                table: "Destinos",
                newName: "Uf");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Destinos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "destino",
                table: "Destinos",
                newName: "Cidade");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinos",
                table: "Destinos",
                column: "Id");
        }
    }
}
