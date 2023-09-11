using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webenglishfinal.Migrations
{
    public partial class huy2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catalouges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catalouges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "detailGradeAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detailGradeAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "detailRoleAccounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountusername = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detailRoleAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detailRoleAccounts_accounts_accountusername",
                        column: x => x.accountusername,
                        principalTable: "accounts",
                        principalColumn: "username");
                    table.ForeignKey(
                        name: "FK_detailRoleAccounts_roles_roleId",
                        column: x => x.roleId,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lessons",
                columns: table => new
                {
                    IdLesson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameLesson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lessons", x => x.IdLesson);
                });

            migrationBuilder.CreateTable(
                name: "ranks",
                columns: table => new
                {
                    idRank = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ranks", x => x.idRank);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detailRoleAccounts_accountusername",
                table: "detailRoleAccounts",
                column: "accountusername");

            migrationBuilder.CreateIndex(
                name: "IX_detailRoleAccounts_roleId",
                table: "detailRoleAccounts",
                column: "roleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catalouges");

            migrationBuilder.DropTable(
                name: "detailGradeAccounts");

            migrationBuilder.DropTable(
                name: "detailRoleAccounts");

            migrationBuilder.DropTable(
                name: "lessons");

            migrationBuilder.DropTable(
                name: "ranks");
        }
    }
}
