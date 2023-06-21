using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "SubTitle", "Title", "Type", "UpdatedAt", "UseCase" },
                values: new object[,]
                {
                    { new Guid("61b5a1b3-e6d3-49a7-8bf0-e9d5ba585c18"), null, null, "Description", "SubTitle", "Title", "terms", null, "terms" },
                    { new Guid("61f54f5d-5076-4449-9e06-1749ae675dea"), null, null, "Description", "SubTitle", "Title", "aboutUs", null, "aboutUs" },
                    { new Guid("af233cad-d72c-4823-a7eb-b9c942aa9609"), null, null, "Description", "SubTitle", "Title", "homeBanner1", null, "homeBanner1" },
                    { new Guid("d1827b50-ec7c-40bc-9f39-a87e96a45264"), null, null, "Description", "SubTitle", "Title", "homeBanner2", null, "homeBanner2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("61b5a1b3-e6d3-49a7-8bf0-e9d5ba585c18"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("61f54f5d-5076-4449-9e06-1749ae675dea"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("af233cad-d72c-4823-a7eb-b9c942aa9609"));

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: new Guid("d1827b50-ec7c-40bc-9f39-a87e96a45264"));
        }
    }
}
