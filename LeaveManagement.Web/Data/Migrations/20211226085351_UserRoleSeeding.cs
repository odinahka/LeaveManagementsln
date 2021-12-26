using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UserRoleSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b062d856-433d-4b10-92d2-721e3e45343d", "94f8ccb3-0022-499d-b70a-17d6e84bfc54", "User", "USER" },
                    { "c118fd0f-ad21-4ae9-aa1b-2217a9e86477", "9de53994-c738-40c8-9377-7e05deaab094", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "49f62bbb-1296-44a6-9879-1bd18a65f6c6", 0, "131394c7-da27-4ca0-a63d-dd0dcb30b1ca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nobelshaka@gmail.com", false, "Odinaka", "Afocha", false, null, "NOBELSHAKA@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGaIQbCfaEcPIRalRgPkbuR3H0GqZu0GuD6JDAFK5dblzq31zsKecfOuoG+scpL3tg==", null, false, "3e82917b-054a-4d16-a470-46ea2db7df9c", null, false, null },
                    { "9d36312a-6fe4-4a5b-ae46-0b3414039109", 0, "7620f2c0-d452-4180-a081-73959a923ba8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", false, "Odinaka", "Afocha", false, null, "USER@USER.COM", null, "AQAAAAEAACcQAAAAEGshaHEezYZdBtcn90v3P4m/34jyKfM3h/j1Y5JzLYPi9SXcFOqprMDzZ+5TEopSxg==", null, false, "a97c1eeb-445d-43e8-9bea-029350db14e5", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c118fd0f-ad21-4ae9-aa1b-2217a9e86477", "49f62bbb-1296-44a6-9879-1bd18a65f6c6" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b062d856-433d-4b10-92d2-721e3e45343d", "9d36312a-6fe4-4a5b-ae46-0b3414039109" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c118fd0f-ad21-4ae9-aa1b-2217a9e86477", "49f62bbb-1296-44a6-9879-1bd18a65f6c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b062d856-433d-4b10-92d2-721e3e45343d", "9d36312a-6fe4-4a5b-ae46-0b3414039109" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b062d856-433d-4b10-92d2-721e3e45343d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c118fd0f-ad21-4ae9-aa1b-2217a9e86477");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49f62bbb-1296-44a6-9879-1bd18a65f6c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d36312a-6fe4-4a5b-ae46-0b3414039109");
        }
    }
}
