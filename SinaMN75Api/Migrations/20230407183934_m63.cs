using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m63 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_BookmarkFolderEntity_BookmarkFolderEntityId",
                table: "Media");

            migrationBuilder.DropTable(
                name: "BookmarkEntityBookmarkFolderEntity");

            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropTable(
                name: "BookmarkFolderEntity");

            migrationBuilder.DropIndex(
                name: "IX_Media_BookmarkFolderEntityId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "BookmarkFolderEntityId",
                table: "Media");

            migrationBuilder.AddColumn<string>(
                name: "FollowingUsers",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FollowingUsers",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "BookmarkFolderEntityId",
                table: "Media",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookmarkFolderEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                name: "Follows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FollowerUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FollowsUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Follows_AspNetUsers_FollowerUserId",
                        column: x => x.FollowerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Follows_AspNetUsers_FollowsUserId",
                        column: x => x.FollowsUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "IX_BookmarkEntityBookmarkFolderEntity_BookmarksId",
                table: "BookmarkEntityBookmarkFolderEntity",
                column: "BookmarksId");

            migrationBuilder.CreateIndex(
                name: "IX_BookmarkFolderEntity_UserId",
                table: "BookmarkFolderEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FollowerUserId",
                table: "Follows",
                column: "FollowerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FollowsUserId",
                table: "Follows",
                column: "FollowsUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_BookmarkFolderEntity_BookmarkFolderEntityId",
                table: "Media",
                column: "BookmarkFolderEntityId",
                principalTable: "BookmarkFolderEntity",
                principalColumn: "Id");
        }
    }
}
