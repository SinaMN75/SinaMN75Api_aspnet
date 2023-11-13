using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m21 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "FormFields");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: true),
                    Label = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OptionList = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormFields_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormFieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_Categories_CategoryEntityId",
                        column: x => x.CategoryEntityId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_FormFields_FormFieldId",
                        column: x => x.FormFieldId,
                        principalTable: "FormFields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Forms_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_CategoryId",
                table: "FormFields",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_CategoryEntityId",
                table: "Forms",
                column: "CategoryEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_FormFieldId",
                table: "Forms",
                column: "FormFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_ProductId",
                table: "Forms",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_UserId",
                table: "Forms",
                column: "UserId");
        }
    }
}
