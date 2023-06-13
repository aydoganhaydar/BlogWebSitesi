using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Dal.Migrations
{
    public partial class appuserpasswordsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f56f7ece-7095-4cf3-8af9-d3276582c9f1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AppUserPasswords",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8a7e621-6393-4b7f-9fcd-510de6771973", "9810b4f2-b0aa-43a0-afb7-77cb6baf8a48", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8a7e621-6393-4b7f-9fcd-510de6771973");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AppUserPasswords");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f56f7ece-7095-4cf3-8af9-d3276582c9f1", "fdc5a040-9c5a-4b1e-9f4a-dc9be86aafb6", "Member", "MEMBER" });
        }
    }
}
