using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reaction_Users_UserId",
                table: "Reaction");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reaction",
                newName: "UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Reaction_UserId",
                table: "Reaction",
                newName: "IX_Reaction_UserEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Users_UserEntityId",
                table: "Reaction",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reaction_Users_UserEntityId",
                table: "Reaction");

            migrationBuilder.RenameColumn(
                name: "UserEntityId",
                table: "Reaction",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reaction_UserEntityId",
                table: "Reaction",
                newName: "IX_Reaction_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reaction_Users_UserId",
                table: "Reaction",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
