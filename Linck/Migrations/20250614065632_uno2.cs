using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linck.Migrations
{
    /// <inheritdoc />
    public partial class uno2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Link_Categoria_CategoriaId",
                table: "Link");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "categorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categorias",
                table: "categorias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Link_categorias_CategoriaId",
                table: "Link",
                column: "CategoriaId",
                principalTable: "categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Link_categorias_CategoriaId",
                table: "Link");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categorias",
                table: "categorias");

            migrationBuilder.RenameTable(
                name: "categorias",
                newName: "Categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Categoria_CategoriaId",
                table: "Link",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
