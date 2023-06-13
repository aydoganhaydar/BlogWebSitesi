using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Dal.Migrations
{
    public partial class UpdateAppUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2f6ef69-cea9-4fe8-95c4-dfeea55d3b2e");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "AppUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bbc9247e-6374-4d86-8f1f-09921d0d3697", "05ea8c9c-63f3-4c70-8e87-75e73c97050a", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbc9247e-6374-4d86-8f1f-09921d0d3697");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "AppUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2f6ef69-cea9-4fe8-95c4-dfeea55d3b2e", "2bd10b95-ac2d-4796-bd62-a9d2e69d62aa", "Member", "MEMBER" });
        }
    }
}
