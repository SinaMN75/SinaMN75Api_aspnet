using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m65 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Bookmarks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookmarks_ParentId",
                table: "Bookmarks",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookmarks_Bookmarks_ParentId",
                table: "Bookmarks",
                column: "ParentId",
                principalTable: "Bookmarks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookmarks_Bookmarks_ParentId",
                table: "Bookmarks");

            migrationBuilder.DropIndex(
                name: "IX_Bookmarks_ParentId",
                table: "Bookmarks");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Bookmarks");
        }
    }
}
