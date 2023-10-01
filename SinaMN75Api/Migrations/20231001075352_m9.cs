using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "Transactions");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Transactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Transactions");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransactionType",
                table: "Transactions",
                type: "int",
                nullable: true);
        }
    }
}
