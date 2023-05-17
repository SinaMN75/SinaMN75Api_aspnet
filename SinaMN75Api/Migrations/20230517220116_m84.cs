using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SinaMN75Api.Migrations
{
    /// <inheritdoc />
    public partial class m84 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecieverPhoneNumber",
                table: "Address",
                newName: "ReceiverPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "RecieverFullName",
                table: "Address",
                newName: "ReceiverFullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceiverPhoneNumber",
                table: "Address",
                newName: "RecieverPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ReceiverFullName",
                table: "Address",
                newName: "RecieverFullName");
        }
    }
}
