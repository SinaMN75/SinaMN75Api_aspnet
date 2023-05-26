using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m96 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBoosted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsBoosted",
                table: "GroupChat");

            migrationBuilder.RenameColumn(
                name: "IsAuthorize",
                table: "AspNetUsers",
                newName: "IsAuthenticated");

            migrationBuilder.AddColumn<DateTime>(
                name: "Boosted",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Boosted",
                table: "GroupChat",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Boosted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Boosted",
                table: "GroupChat");

            migrationBuilder.RenameColumn(
                name: "IsAuthenticated",
                table: "AspNetUsers",
                newName: "IsAuthorize");

            migrationBuilder.AddColumn<bool>(
                name: "IsBoosted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBoosted",
                table: "GroupChat",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
