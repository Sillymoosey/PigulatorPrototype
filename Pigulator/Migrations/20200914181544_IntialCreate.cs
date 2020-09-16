using Microsoft.EntityFrameworkCore.Migrations;

namespace Pigulator.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pigulator",
                columns: table => new
                {
                    PigID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WholePig = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    HalfPig = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pigulator", x => x.PigID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pigulator");
        }
    }
}
