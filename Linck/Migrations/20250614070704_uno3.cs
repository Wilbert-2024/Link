using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linck.Migrations
{
    /// <inheritdoc />
    public partial class uno3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.CreateTable(
                name: "linkss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BovedaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_linkss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_linkss_boveda_BovedaId",
                        column: x => x.BovedaId,
                        principalTable: "boveda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_linkss_categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_linkss_BovedaId",
                table: "linkss",
                column: "BovedaId");

            migrationBuilder.CreateIndex(
                name: "IX_linkss_CategoriaId",
                table: "linkss",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "linkss");

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BovedaId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ImagenLink = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nom_link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Link_boveda_BovedaId",
                        column: x => x.BovedaId,
                        principalTable: "boveda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Link_categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Link_BovedaId",
                table: "Link",
                column: "BovedaId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_CategoriaId",
                table: "Link",
                column: "CategoriaId");
        }
    }
}
