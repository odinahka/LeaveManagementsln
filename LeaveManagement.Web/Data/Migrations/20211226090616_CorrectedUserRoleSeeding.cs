using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class CorrectedUserRoleSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f0e130ee-ef71-4c1f-905b-9439b2dc499e", "NOBELSHAKA@GMAIL@GMAIL.COM", "AQAAAAEAACcQAAAAEKIkxGnd86AQVeJZs6ZevMaSZZakcfpmZE5xeGlL6B+zxbm/uDwp6nh4UqWpEZUzKQ==", "60b14989-571e-449a-bc57-ddaa05ed2ef7", "nobelshaka@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "35b7f42a-9491-46d2-9741-f3a546b97f09", "USER@USER.COM", "AQAAAAEAACcQAAAAEI0X269TOttX32BzuItiSUq1cp5fjUTUqLQN7T1FxkFbSeRxwJ1WVLPXQC2yO35zyg==", "35d6b2e4-42d1-484b-a8d6-af92f3d386a5", "user@user.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "94f8ccb3-0022-499d-b70a-17d6e84bfc54");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "9de53994-c738-40c8-9377-7e05deaab094");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "131394c7-da27-4ca0-a63d-dd0dcb30b1ca", null, "AQAAAAEAACcQAAAAEGaIQbCfaEcPIRalRgPkbuR3H0GqZu0GuD6JDAFK5dblzq31zsKecfOuoG+scpL3tg==", "3e82917b-054a-4d16-a470-46ea2db7df9c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7620f2c0-d452-4180-a081-73959a923ba8", null, "AQAAAAEAACcQAAAAEGshaHEezYZdBtcn90v3P4m/34jyKfM3h/j1Y5JzLYPi9SXcFOqprMDzZ+5TEopSxg==", "a97c1eeb-445d-43e8-9bea-029350db14e5", null });
        }
    }
}
