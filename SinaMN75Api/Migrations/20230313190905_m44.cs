using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m44 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CommentId",
                table: "Reports",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CommentId",
                table: "Reports",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Comment_CommentId",
                table: "Reports",
                column: "CommentId",
                principalTable: "Comment",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Comment_CommentId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_CommentId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Reports");
        }
    }
}
