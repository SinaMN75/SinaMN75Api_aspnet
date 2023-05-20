using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m86 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductState",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ShippingCost",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ShippingTime",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeliCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShebaNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductState",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShippingCost",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShippingTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MeliCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShebaNumber",
                table: "AspNetUsers");
        }
    }
}
