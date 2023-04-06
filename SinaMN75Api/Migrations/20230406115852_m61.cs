using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    public partial class m61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryEntityOrderDetailEntity");

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "OrderDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Stock",
                table: "Categories",
                type: "float",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_CategoryId",
                table: "OrderDetail",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Categories_CategoryId",
                table: "OrderDetail",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Categories_CategoryId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_CategoryId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "CategoryEntityOrderDetailEntity",
                columns: table => new
                {
                    CategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEntityOrderDetailEntity", x => new { x.CategoriesId, x.OrderDetailsId });
                    table.ForeignKey(
                        name: "FK_CategoryEntityOrderDetailEntity_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryEntityOrderDetailEntity_OrderDetail_OrderDetailsId",
                        column: x => x.OrderDetailsId,
                        principalTable: "OrderDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEntityOrderDetailEntity_OrderDetailsId",
                table: "CategoryEntityOrderDetailEntity",
                column: "OrderDetailsId");
        }
    }
}
