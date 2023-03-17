using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "GroupChatMessage",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatorUserId",
                table: "GroupChat",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_ParentId",
                table: "GroupChatMessage",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupChatMessage_GroupChatMessage_ParentId",
                table: "GroupChatMessage",
                column: "ParentId",
                principalTable: "GroupChatMessage",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupChatMessage_GroupChatMessage_ParentId",
                table: "GroupChatMessage");

            migrationBuilder.DropIndex(
                name: "IX_GroupChatMessage_ParentId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "GroupChat");
        }
    }
}
