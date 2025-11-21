using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linck.Migrations
{
    /// <inheritdoc />
    public partial class uno1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boveda_usuarios_UsuarioId",
                table: "Boveda");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_Boveda_BovedaId",
                table: "Link");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boveda",
                table: "Boveda");

            migrationBuilder.RenameTable(
                name: "Boveda",
                newName: "boveda");

            migrationBuilder.RenameIndex(
                name: "IX_Boveda_UsuarioId",
                table: "boveda",
                newName: "IX_boveda_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_boveda",
                table: "boveda",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_boveda_usuarios_UsuarioId",
                table: "boveda",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_boveda_BovedaId",
                table: "Link",
                column: "BovedaId",
                principalTable: "boveda",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_boveda_usuarios_UsuarioId",
                table: "boveda");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_boveda_BovedaId",
                table: "Link");

            migrationBuilder.DropPrimaryKey(
                name: "PK_boveda",
                table: "boveda");

            migrationBuilder.RenameTable(
                name: "boveda",
                newName: "Boveda");

            migrationBuilder.RenameIndex(
                name: "IX_boveda_UsuarioId",
                table: "Boveda",
                newName: "IX_Boveda_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boveda",
                table: "Boveda",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Boveda_usuarios_UsuarioId",
                table: "Boveda",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_Boveda_BovedaId",
                table: "Link",
                column: "BovedaId",
                principalTable: "Boveda",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
