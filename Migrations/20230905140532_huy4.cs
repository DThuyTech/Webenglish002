using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webenglishfinal.Migrations
{
    public partial class huy4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "exercise",
                columns: table => new
                {
                    IdExe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exercise", x => x.IdExe);
                });

            migrationBuilder.CreateTable(
                name: "recommands",
                columns: table => new
                {
                    IdRecommand = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recommands", x => x.IdRecommand);
                });

            migrationBuilder.CreateTable(
                name: "statuses",
                columns: table => new
                {
                    Idstatus = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statuses", x => x.Idstatus);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "exercise");

            migrationBuilder.DropTable(
                name: "recommands");

            migrationBuilder.DropTable(
                name: "statuses");
        }
    }
}
