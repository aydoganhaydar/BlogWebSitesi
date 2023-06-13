using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Dal.Migrations
{
    public partial class appuserpasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbc9247e-6374-4d86-8f1f-09921d0d3697");

            migrationBuilder.CreateTable(
                name: "AppUserPasswords",
                columns: table => new
                {
                    AppUserID = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserPasswords", x => x.AppUserID);
                    table.ForeignKey(
                        name: "FK_AppUserPasswords_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f56f7ece-7095-4cf3-8af9-d3276582c9f1", "fdc5a040-9c5a-4b1e-9f4a-dc9be86aafb6", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserPasswords");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f56f7ece-7095-4cf3-8af9-d3276582c9f1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bbc9247e-6374-4d86-8f1f-09921d0d3697", "05ea8c9c-63f3-4c70-8e87-75e73c97050a", "Member", "MEMBER" });
        }
    }
}
