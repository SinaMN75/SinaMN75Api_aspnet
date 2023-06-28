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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductAttributeId",
                table: "OrderDetail",
                column: "ProductAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_ProductAttributeEntity_ProductAttributeId",
                table: "OrderDetail",
                column: "ProductAttributeId",
                principalTable: "ProductAttributeEntity",
                principalColumn: "Id");
        }
    }
}
