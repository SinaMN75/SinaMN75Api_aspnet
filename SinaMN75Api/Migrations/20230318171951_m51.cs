using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductUseCase",
                table: "Reports");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatId",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupChatId",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GroupChatMessageId",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ChatId",
                table: "Reports",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GroupChatId",
                table: "Reports",
                column: "GroupChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_GroupChatMessageId",
                table: "Reports",
                column: "GroupChatMessageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Chats_ChatId",
                table: "Reports",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_GroupChat_GroupChatId",
                table: "Reports",
                column: "GroupChatId",
                principalTable: "GroupChat",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_GroupChatMessage_GroupChatMessageId",
                table: "Reports",
                column: "GroupChatMessageId",
                principalTable: "GroupChatMessage",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Chats_ChatId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_GroupChat_GroupChatId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_GroupChatMessage_GroupChatMessageId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ChatId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_GroupChatId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_GroupChatMessageId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "GroupChatId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "GroupChatMessageId",
                table: "Reports");

            migrationBuilder.AddColumn<string>(
                name: "ProductUseCase",
                table: "Reports",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }
    }
}
