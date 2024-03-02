using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_SubscriptionPayment_SubscriptionPaymentId",
                table: "Transactions");

            migrationBuilder.DropTable(
                name: "SubscriptionPayment");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_SubscriptionPaymentId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AgeCategory",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CommentCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ExpireUpgradeAccount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsOnline",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserAgent",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "SubscriptionPaymentId",
                table: "Transactions");

            migrationBuilder.AddColumn<DateTime>(
                name: "PremiumExpireDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Products",
                type: "integer[]",
                maxLength: 100,
                nullable: false,
                defaultValue: new int[0],
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Notifications",
                type: "integer[]",
                maxLength: 100,
                nullable: false,
                defaultValue: new int[0],
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Media",
                type: "integer[]",
                maxLength: 100,
                nullable: false,
                defaultValue: new int[0],
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Comment",
                type: "integer[]",
                maxLength: 100,
                nullable: false,
                defaultValue: new int[0],
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiumExpireDate",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "AgeCategory",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentCount",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpireUpgradeAccount",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOnline",
                table: "Users",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserAgent",
                table: "Users",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionId",
                table: "Transactions",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionPaymentId",
                table: "Transactions",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Products",
                type: "integer[]",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Notifications",
                type: "integer[]",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Media",
                type: "integer[]",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int[]>(
                name: "Tags",
                table: "Comment",
                type: "integer[]",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "SubscriptionPayment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PromotionId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PayDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SubscriptionType = table.Column<int>(type: "integer", nullable: false),
                    Tag = table.Column<int>(type: "integer", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPayment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionPayment_Promotion_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "Promotion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubscriptionPayment_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_SubscriptionPaymentId",
                table: "Transactions",
                column: "SubscriptionPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPayment_PromotionId",
                table: "SubscriptionPayment",
                column: "PromotionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionPayment_UserId",
                table: "SubscriptionPayment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_SubscriptionPayment_SubscriptionPaymentId",
                table: "Transactions",
                column: "SubscriptionPaymentId",
                principalTable: "SubscriptionPayment",
                principalColumn: "Id");
        }
    }
}
