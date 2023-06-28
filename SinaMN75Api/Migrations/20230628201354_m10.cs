using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Categories",
                type: "int",
                nullable: true);
        }
    }
}
