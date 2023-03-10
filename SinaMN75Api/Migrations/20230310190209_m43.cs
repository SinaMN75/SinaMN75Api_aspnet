using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Chats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chats_ParentId",
                table: "Chats",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Chats_ParentId",
                table: "Chats",
                column: "ParentId",
                principalTable: "Chats",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Chats_ParentId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_ParentId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Chats");
        }
    }
}
