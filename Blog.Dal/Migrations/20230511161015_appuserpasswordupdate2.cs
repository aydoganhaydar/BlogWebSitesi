using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Dal.Migrations
{
    public partial class appuserpasswordupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserPasswords",
                table: "AppUserPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8a7e621-6393-4b7f-9fcd-510de6771973");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "AppUserPasswords",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserPasswords",
                table: "AppUserPasswords",
                column: "ID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7334bb3-7298-46d8-b36d-bd8d669cbd0e", "b6e24091-8861-4801-aaab-50620082a3c2", "Member", "MEMBER" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserPasswords_AppUserID",
                table: "AppUserPasswords",
                column: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserPasswords",
                table: "AppUserPasswords");

            migrationBuilder.DropIndex(
                name: "IX_AppUserPasswords_AppUserID",
                table: "AppUserPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7334bb3-7298-46d8-b36d-bd8d669cbd0e");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "AppUserPasswords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserPasswords",
                table: "AppUserPasswords",
                column: "AppUserID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8a7e621-6393-4b7f-9fcd-510de6771973", "9810b4f2-b0aa-43a0-afb7-77cb6baf8a48", "Member", "MEMBER" });
        }
    }
}
