using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class EmailConfirmedIncluded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c44ae84-4801-40db-8f43-16ea4aa60d03", true, "AQAAAAEAACcQAAAAEAzadlSbIFzNHmNdCo7Ta7XuLn6gQnaTgi2WmQZXB4OQ6p7fgmVp7oHDWj/RW5/EVQ==", "5604b820-1967-4442-9d8b-eef308efa5f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebf00811-3995-47bb-9708-f49a5201f9d5", true, "AQAAAAEAACcQAAAAEGlI7Pftzywy+GgloU0R9stq5x0QJD27l4uYliOA7U808s/ZRjmLZ0ZAJYhdxyc7MQ==", "980faaac-e813-441f-ae50-ffab8cc2b16c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "6d7cc210-693c-4074-a854-c1639cee31d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "b75d8f30-bb95-450e-817e-b28acec0ea8e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e130ee-ef71-4c1f-905b-9439b2dc499e", false, "AQAAAAEAACcQAAAAEKIkxGnd86AQVeJZs6ZevMaSZZakcfpmZE5xeGlL6B+zxbm/uDwp6nh4UqWpEZUzKQ==", "60b14989-571e-449a-bc57-ddaa05ed2ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35b7f42a-9491-46d2-9741-f3a546b97f09", false, "AQAAAAEAACcQAAAAEI0X269TOttX32BzuItiSUq1cp5fjUTUqLQN7T1FxkFbSeRxwJ1WVLPXQC2yO35zyg==", "35d6b2e4-42d1-484b-a8d6-af92f3d386a5" });
        }
    }
}
