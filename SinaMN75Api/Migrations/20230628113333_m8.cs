using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderDetail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "Products",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderDetail",
                type: "float",
                nullable: true);
        }
    }
}
