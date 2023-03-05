using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Chats_ChatId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ChatId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ChatId",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ChatEntityProductEntity",
                columns: table => new
                {
                    ChatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatEntityProductEntity", x => new { x.ChatsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ChatEntityProductEntity_Chats_ChatsId",
                        column: x => x.ChatsId,
                        principalTable: "Chats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ChatEntityProductEntity_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatEntityProductEntity_ProductsId",
                table: "ChatEntityProductEntity",
                column: "ProductsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatEntityProductEntity");

            migrationBuilder.AddColumn<Guid>(
                name: "ChatId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ChatId",
                table: "Products",
                column: "ChatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Chats_ChatId",
                table: "Products",
                column: "ChatId",
                principalTable: "Chats",
                principalColumn: "Id");
        }
    }
}
