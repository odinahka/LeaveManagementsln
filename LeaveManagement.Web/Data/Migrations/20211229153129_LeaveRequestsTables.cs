using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveRequestsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d",
                column: "ConcurrencyStamp",
                value: "e65f1a79-4688-4172-933e-6ca58bfed6d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477",
                column: "ConcurrencyStamp",
                value: "88cdc4b7-c8ce-4df4-8737-49f6baa55b4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f7e19c7-2343-4e66-beca-4e0b027f2e3d", "AQAAAAEAACcQAAAAEFXkz7OtgDeqv0Ez33t5gMNhACjdFwzfVCOwOWCa5wthIlYHNg0jTEeGo8j956mvZQ==", "774551a8-82e9-4aba-bc2f-a329f63e0de5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0d1d26-0c3c-444f-b9c7-34a619689b52", "AQAAAAEAACcQAAAAEP9pQgP2jUw097SNcnEqhTSTLjH/zz/mzFObsBpKb0oAjsWth9oIwylCuSNe1SFxNQ==", "b4a7194c-9304-453d-9c3b-bf436bd8a7b6" });
        }
    }
}
