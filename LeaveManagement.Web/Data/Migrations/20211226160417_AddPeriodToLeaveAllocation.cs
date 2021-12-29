using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9276a800-2edb-4082-b9af-f2fd07e208c0", "AQAAAAEAACcQAAAAEIVopTiqWvRqYaU+jzMirx/DnBKpzCl33TdnAJoa5QISjzSiZPH1acG5SAsPN4IqCg==", "5c1f55a4-3bfb-4bfb-9b98-6411f88d696f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21105fd5-802e-4d47-ad0c-72feeeb73b31", "AQAAAAEAACcQAAAAEAC6iw9uq9jqmL1sLcB3MQRHpRuqOA3CdI3kHhpP9W0ua7Hg/S0S7WfltAs8riu8mQ==", "6a255af3-7673-419c-95a7-f7756af66be7" });
        }
    }
}
