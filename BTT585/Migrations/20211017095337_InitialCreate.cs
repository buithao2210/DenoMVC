using Microsoft.EntityFrameworkCore.Migrations;

namespace BTT585.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BTT2210",
                columns: table => new
                {
                    BTTId = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BTTName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    BTTGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BTT2210", x => x.BTTId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BTT2210");
        }
    }
}
