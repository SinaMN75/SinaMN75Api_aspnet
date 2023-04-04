using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsersSeen",
                table: "GroupChatMessage");

            migrationBuilder.AddColumn<Guid>(
                name: "BookmarkFolderEntityId",
                table: "Media",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SeenUsersId",
                table: "GroupChatMessage",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UseCase",
                table: "AspNetUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookmarkFolderEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookmarkFolderEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookmarkFolderEntity_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SeenUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fk_GroupChat = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Fk_UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_GroupChatMessage = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeenUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookmarkEntityBookmarkFolderEntity",
                columns: table => new
                {
                    BookmarkFoldersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookmarksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookmarkEntityBookmarkFolderEntity", x => new { x.BookmarkFoldersId, x.BookmarksId });
                    table.ForeignKey(
                        name: "FK_BookmarkEntityBookmarkFolderEntity_BookmarkFolderEntity_BookmarkFoldersId",
                        column: x => x.BookmarkFoldersId,
                        principalTable: "BookmarkFolderEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookmarkEntityBookmarkFolderEntity_Bookmarks_BookmarksId",
                        column: x => x.BookmarksId,
                        principalTable: "Bookmarks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Media_BookmarkFolderEntityId",
                table: "Media",
                column: "BookmarkFolderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupChatMessage_SeenUsersId",
                table: "GroupChatMessage",
                column: "SeenUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_BookmarkEntityBookmarkFolderEntity_BookmarksId",
                table: "BookmarkEntityBookmarkFolderEntity",
                column: "BookmarksId");

            migrationBuilder.CreateIndex(
                name: "IX_BookmarkFolderEntity_UserId",
                table: "BookmarkFolderEntity",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupChatMessage_SeenUsers_SeenUsersId",
                table: "GroupChatMessage",
                column: "SeenUsersId",
                principalTable: "SeenUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_BookmarkFolderEntity_BookmarkFolderEntityId",
                table: "Media",
                column: "BookmarkFolderEntityId",
                principalTable: "BookmarkFolderEntity",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupChatMessage_SeenUsers_SeenUsersId",
                table: "GroupChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_BookmarkFolderEntity_BookmarkFolderEntityId",
                table: "Media");

            migrationBuilder.DropTable(
                name: "BookmarkEntityBookmarkFolderEntity");

            migrationBuilder.DropTable(
                name: "SeenUsers");

            migrationBuilder.DropTable(
                name: "BookmarkFolderEntity");

            migrationBuilder.DropIndex(
                name: "IX_Media_BookmarkFolderEntityId",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_GroupChatMessage_SeenUsersId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "BookmarkFolderEntityId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "SeenUsersId",
                table: "GroupChatMessage");

            migrationBuilder.DropColumn(
                name: "UseCase",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UsersSeen",
                table: "GroupChatMessage",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
