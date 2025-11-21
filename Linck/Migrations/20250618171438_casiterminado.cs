using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linck.Migrations
{
    /// <inheritdoc />
    public partial class casiterminado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImagenLink",
                table: "linkss",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenLink",
                table: "linkss");
        }
    }
}
