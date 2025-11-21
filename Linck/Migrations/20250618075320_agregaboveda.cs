using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Linck.Migrations
{
    /// <inheritdoc />
    public partial class agregaboveda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contrasena",
                table: "boveda",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contrasena",
                table: "boveda");
        }
    }
}
