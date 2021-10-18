using Microsoft.EntityFrameworkCore.Migrations;

namespace Page.Migrations
{
    public partial class Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Add",
                columns: table => new
                {
                    AddId = table.Column<string>(type: "varchar(20)", nullable: false),
                    AddName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Add", x => x.AddId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Add");
        }
    }
}
