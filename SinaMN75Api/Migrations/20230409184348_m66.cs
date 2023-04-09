using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m66 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupChatMessage_AspNetUsers_ForwardedFromUserId",
                table: "GroupChatMessage");

            migrationBuilder.DropIndex(
                name: "IX_GroupChatMessage_ForwardedFromUserId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "ForwardedFromUserId",
                table: "GroupChatMessage");

            migrationBuilder.AddColumn<Guid>(
                name: "ForwardedMessageId",
                table: "GroupChatMessage",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_ForwardedMessageId",
                table: "GroupChatMessage",
                column: "ForwardedMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupChatMessage_GroupChatMessage_ForwardedMessageId",
                table: "GroupChatMessage",
                column: "ForwardedMessageId",
                principalTable: "GroupChatMessage",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupChatMessage_GroupChatMessage_ForwardedMessageId",
                table: "GroupChatMessage");

            migrationBuilder.DropIndex(
                name: "IX_GroupChatMessage_ForwardedMessageId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "ForwardedMessageId",
                table: "GroupChatMessage");

            migrationBuilder.AddColumn<string>(
                name: "ForwardedFromUserId",
                table: "GroupChatMessage",
                type: "nvarchar(450)",
                nullable: true);

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
    }
}
