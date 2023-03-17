using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m48 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GroupChatMessageEntityId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_GroupChatMessageEntityId",
                table: "Products",
                column: "GroupChatMessageEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_GroupChatMessage_GroupChatMessageEntityId",
                table: "Products",
                column: "GroupChatMessageEntityId",
                principalTable: "GroupChatMessage",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_GroupChatMessage_GroupChatMessageEntityId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_GroupChatMessageEntityId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GroupChatMessageEntityId",
                table: "Products");
        }
    }
}
