using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m58 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ForwardedFromId",
                table: "GroupChatMessage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForwardedFromUserId",
                table: "GroupChatMessage",
                type: "nvarchar(max)",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ForwardedFromUserId",
                table: "GroupChatMessage");
        }
    }
}
