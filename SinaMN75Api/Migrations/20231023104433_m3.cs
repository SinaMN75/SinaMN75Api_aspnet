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
            migrationBuilder.DropForeignKey(
                name: "FK_Withdraw_Users_UserId",
                table: "Withdraw");

            migrationBuilder.AlterColumn<int>(
                name: "WithdrawState",
                table: "Withdraw",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Withdraw",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Withdraw",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdminMessage",
                table: "Withdraw",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommetCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TargetUserId",
                table: "Comment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_TargetUserId",
                table: "Comment",
                column: "TargetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Users_TargetUserId",
                table: "Comment",
                column: "TargetUserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Withdraw_Users_UserId",
                table: "Withdraw",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Users_TargetUserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Withdraw_Users_UserId",
                table: "Withdraw");

            migrationBuilder.DropIndex(
                name: "IX_Comment_TargetUserId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AdminMessage",
                table: "Withdraw");

            migrationBuilder.DropColumn(
                name: "CommetCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TargetUserId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "WithdrawState",
                table: "Withdraw",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Withdraw",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Withdraw",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Withdraw_Users_UserId",
                table: "Withdraw",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
