using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Categories_CategoryId",
                table: "OrderDetail");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "OrderDetail",
                newName: "ProductAttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_CategoryId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_ProductAttributeId");

            migrationBuilder.CreateTable(
                name: "ProductAttributeEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    DiscountedPrice = table.Column<double>(type: "float", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_ProductAttributeEntity_ProductAttributeId",
                table: "OrderDetail");

            migrationBuilder.DropTable(
                name: "ProductAttributeEntity");

            migrationBuilder.RenameColumn(
                name: "ProductAttributeId",
                table: "OrderDetail",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_ProductAttributeId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Categories_CategoryId",
                table: "OrderDetail",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
