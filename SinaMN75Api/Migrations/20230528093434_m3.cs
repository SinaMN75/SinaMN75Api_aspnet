using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JsonDetail",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "VisitsCount",
                table: "Products",
                newName: "CommentsCount");

            migrationBuilder.AlterColumn<string>(
                name: "Teams",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Media",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Media");

            migrationBuilder.RenameColumn(
                name: "CommentsCount",
                table: "Products",
                newName: "VisitsCount");

            migrationBuilder.AddColumn<string>(
                name: "JsonDetail",
                table: "Transactions",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Teams",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
