using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_ProductAttributeEntity_ProductAttributeId",
                table: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ProductAttributeEntity");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_ProductAttributeId",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ProductAttributeId",
                table: "OrderDetail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductAttributeId",
                table: "OrderDetail",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductAttributeEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountedPrice = table.Column<double>(type: "float", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeEntity_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductAttributeId",
                table: "OrderDetail",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeEntity_ProductId",
                table: "ProductAttributeEntity",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_ProductAttributeEntity_ProductAttributeId",
                table: "OrderDetail",
                column: "ProductAttributeId",
                principalTable: "ProductAttributeEntity",
                principalColumn: "Id");
        }
    }
}
