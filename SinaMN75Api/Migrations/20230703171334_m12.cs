using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_GroupChat_GroupChatEntityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GroupChatEntityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GroupChatEntityId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "GroupChatEntityUserEntity",
                columns: table => new
                {
                    GroupChatsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupChatEntityUserEntity", x => new { x.GroupChatsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GroupChatEntityUserEntity_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupChatEntityUserEntity_GroupChat_GroupChatsId",
                        column: x => x.GroupChatsId,
                        principalTable: "GroupChat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatEntityUserEntity_UsersId",
                table: "GroupChatEntityUserEntity",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupChatEntityUserEntity");

            migrationBuilder.AddColumn<Guid>(
                name: "GroupChatEntityId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GroupChatEntityId",
                table: "AspNetUsers",
                column: "GroupChatEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_GroupChat_GroupChatEntityId",
                table: "AspNetUsers",
                column: "GroupChatEntityId",
                principalTable: "GroupChat",
                principalColumn: "Id");
        }
    }
}
