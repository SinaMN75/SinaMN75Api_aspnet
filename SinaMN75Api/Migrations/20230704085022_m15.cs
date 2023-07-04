using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseCase",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "UseCase",
                table: "FormFields");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Media",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Contents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Categories",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("61b5a1b3-e6d3-49a7-8bf0-e9d5ba585c18"),
                column: "Tags",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("61f54f5d-5076-4449-9e06-1749ae675dea"),
                column: "Tags",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("af233cad-d72c-4823-a7eb-b9c942aa9609"),
                column: "Tags",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("d1827b50-ec7c-40bc-9f39-a87e96a45264"),
                column: "Tags",
                value: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Contents");

            migrationBuilder.AddColumn<string>(
                name: "UseCase",
                table: "Forms",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UseCase",
                table: "FormFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                table: "Categories",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
