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
                name: "Authority",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "GatewayName",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "ShebaNumber",
                table: "Transactions",
                newName: "CardNumber");

            migrationBuilder.AlterColumn<string>(
                name: "RefId",
                table: "Transactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardNumber",
                table: "Transactions",
                newName: "ShebaNumber");

            migrationBuilder.AlterColumn<long>(
                name: "RefId",
                table: "Transactions",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Authority",
                table: "Transactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GatewayName",
                table: "Transactions",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentId",
                table: "Transactions",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
