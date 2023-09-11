using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webenglishfinal.Migrations
{
    public partial class huy6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "incorrectSens",
                columns: table => new
                {
                    idSentences = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incorrectSens", x => x.idSentences);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "incorrectSens");
        }
    }
}
