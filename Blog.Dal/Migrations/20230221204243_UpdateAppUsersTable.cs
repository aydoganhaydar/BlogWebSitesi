using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Dal.Migrations
{
    public partial class UpdateAppUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad23e8a1-63c3-4758-96b8-9f85fdb034c6");

            migrationBuilder.AddColumn<int>(
                name: "Onay",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Onay",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Onay",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Onay",
                table: "AppUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2f6ef69-cea9-4fe8-95c4-dfeea55d3b2e", "2bd10b95-ac2d-4796-bd62-a9d2e69d62aa", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2f6ef69-cea9-4fe8-95c4-dfeea55d3b2e");

            migrationBuilder.DropColumn(
                name: "Onay",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Onay",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Onay",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Onay",
                table: "AppUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad23e8a1-63c3-4758-96b8-9f85fdb034c6", "660b83fa-3dd1-48d7-868e-dba59e6fedf1", "Member", "MEMBER" });
        }
    }
}
