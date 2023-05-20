using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m87 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Withdraw",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShebaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    WithdrawState = table.Column<int>(type: "int", nullable: true),
                    ApplicantUserEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicantUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminUserEntityId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AdminUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Withdraw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Withdraw_AspNetUsers_AdminUserEntityId",
                        column: x => x.AdminUserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Withdraw_AspNetUsers_ApplicantUserEntityId",
                        column: x => x.ApplicantUserEntityId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Withdraw_AdminUserEntityId",
                table: "Withdraw",
                column: "AdminUserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Withdraw_ApplicantUserEntityId",
                table: "Withdraw",
                column: "ApplicantUserEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Withdraw");
        }
    }
}
