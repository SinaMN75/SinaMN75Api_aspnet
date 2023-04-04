using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryEntityGroupChatEntity",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupChatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityGroupChatEntity", x => new { x.CategoriesId, x.GroupChatsId });
                    table.ForeignKey(
                        name: "FK_CategoryEntityGroupChatEntity_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryEntityGroupChatEntity_GroupChat_GroupChatsId",
                        column: x => x.GroupChatsId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityGroupChatEntity_GroupChatsId",
                table: "CategoryEntityGroupChatEntity",
                column: "GroupChatsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryEntityGroupChatEntity");
        }
    }
}
