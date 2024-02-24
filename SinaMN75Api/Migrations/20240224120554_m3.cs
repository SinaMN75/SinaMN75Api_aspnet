using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Media",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Media_ParentId",
                table: "Media",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Media_ParentId",
                table: "Media",
                column: "ParentId",
                principalTable: "Media",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Media_ParentId",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_Media_ParentId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Media");
        }
    }
}
