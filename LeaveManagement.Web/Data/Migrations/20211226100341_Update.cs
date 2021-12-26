using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "7289a17a-f189-43b0-ae92-e579939593cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "a1a658e6-34d9-485f-bc9e-f67f3ba67502");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9276a800-2edb-4082-b9af-f2fd07e208c0", "NOBELSHAKA@GMAIL.COM", "AQAAAAEAACcQAAAAEIVopTiqWvRqYaU+jzMirx/DnBKpzCl33TdnAJoa5QISjzSiZPH1acG5SAsPN4IqCg==", "5c1f55a4-3bfb-4bfb-9b98-6411f88d696f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21105fd5-802e-4d47-ad0c-72feeeb73b31", "AQAAAAEAACcQAAAAEAC6iw9uq9jqmL1sLcB3MQRHpRuqOA3CdI3kHhpP9W0ua7Hg/S0S7WfltAs8riu8mQ==", "6a255af3-7673-419c-95a7-f7756af66be7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "19660fb6-ca5c-40a6-b203-0c01dcad7f1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "e246920b-72e3-41d1-a01e-865adc617922");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c44ae84-4801-40db-8f43-16ea4aa60d03", "NOBELSHAKA@GMAIL@GMAIL.COM", "AQAAAAEAACcQAAAAEAzadlSbIFzNHmNdCo7Ta7XuLn6gQnaTgi2WmQZXB4OQ6p7fgmVp7oHDWj/RW5/EVQ==", "5604b820-1967-4442-9d8b-eef308efa5f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf00811-3995-47bb-9708-f49a5201f9d5", "AQAAAAEAACcQAAAAEGlI7Pftzywy+GgloU0R9stq5x0QJD27l4uYliOA7U808s/ZRjmLZ0ZAJYhdxyc7MQ==", "980faaac-e813-441f-ae50-ffab8cc2b16c" });
        }
    }
}
