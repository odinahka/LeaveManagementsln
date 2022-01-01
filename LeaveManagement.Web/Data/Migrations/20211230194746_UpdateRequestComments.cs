using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "5d8f7015-f8ae-4f7e-b63a-4dfbbe450dfc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "07bb1c52-2f0c-42b9-a9d6-67cc1e0a757c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8524216a-ef0e-432e-8822-1637fbc6579f", "AQAAAAEAACcQAAAAEF9fdSnaPdynoZX9DMRAl1P/lmqnFhF3MHId/6DFd6hlNp1IF19cjYrVgaDPrxnM2A==", "ee995b92-8fe6-4033-abc6-0c66aa1d2441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b3e8334-b13c-42c0-b132-f4f2346ba265", "AQAAAAEAACcQAAAAENDFK9UGpg808JuIWO27nvtHLQnTK7IIpW6yb1mgGUsbEjoftycQYANrFaCSF8MTLQ==", "93d89040-f101-47dd-bd4e-13315184cec3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "63ae539c-af9a-4325-b1ae-7ba71824941e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "aa655f80-6cac-4526-9321-0bad1d83720f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7783a14-e742-4b71-a643-bf15c1faeae4", "AQAAAAEAACcQAAAAEFUnzQX44yEELFLHgTSUNa/hT6E4tIJCEPQuhOYkZBYj/xXSqFWBaiprpTfK6GmnGQ==", "4b30083e-e1ba-439a-b6e6-63a2be3dc6f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ebf088-3ecd-48ec-9555-b6b778584fb4", "AQAAAAEAACcQAAAAEGCvQ2a1WHkoEhbIxtAsYJWklpTHbExhiRCsqI5XveGOmY0/TSqR+I+1Hv2x8rsL1A==", "963c9536-2df4-412b-83c5-8396bd9dd922" });
        }
    }
}
