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
            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionPaymentId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SubscriptionPaymentId",
                table: "Transactions",
                column: "SubscriptionPaymentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_SubscriptionPayment_SubscriptionPaymentId",
                table: "Transactions",
                column: "SubscriptionPaymentId",
                principalTable: "SubscriptionPayment",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_SubscriptionPayment_SubscriptionPaymentId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_SubscriptionPaymentId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SubscriptionPaymentId",
                table: "Transactions");
        }
    }
}
