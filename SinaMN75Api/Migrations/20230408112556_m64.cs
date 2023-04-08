using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m64 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupChatMessage_AspNetUsers_ForwardedFromId",
                table: "GroupChatMessage");

            migrationBuilder.DropIndex(
                name: "IX_GroupChatMessage_ForwardedFromId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "ForwardedFromId",
                table: "GroupChatMessage");

            migrationBuilder.AlterColumn<string>(
                name: "ForwardedFromUserId",
                table: "GroupChatMessage",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_ForwardedFromUserId",
                table: "GroupChatMessage",
                column: "ForwardedFromUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupChatMessage_AspNetUsers_ForwardedFromUserId",
                table: "GroupChatMessage",
                column: "ForwardedFromUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupChatMessage_AspNetUsers_ForwardedFromUserId",
                table: "GroupChatMessage");

            migrationBuilder.DropIndex(
                name: "IX_GroupChatMessage_ForwardedFromUserId",
                table: "GroupChatMessage");

            migrationBuilder.AlterColumn<string>(
                name: "ForwardedFromUserId",
                table: "GroupChatMessage",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForwardedFromId",
                table: "GroupChatMessage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_ForwardedFromId",
                table: "GroupChatMessage",
                column: "ForwardedFromId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupChatMessage_AspNetUsers_ForwardedFromId",
                table: "GroupChatMessage",
                column: "ForwardedFromId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
