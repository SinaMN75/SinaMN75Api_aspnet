using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m70 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Notifications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ProductId",
                table: "Notifications",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_Products_ProductId",
                table: "Notifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_Products_ProductId",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_ProductId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Notifications");
        }
    }
}
