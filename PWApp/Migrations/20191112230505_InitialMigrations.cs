using Microsoft.EntityFrameworkCore.Migrations;

namespace PWApp.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeroi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: false),
                    SuperPoder = table.Column<string>(nullable: false),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeroi", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SuperHeroi",
                columns: new[] { "Id", "Foto", "Nome", "SuperPoder" },
                values: new object[] { 1, "/images/b.jpg", "Batman", "Grana" });

            migrationBuilder.InsertData(
                table: "SuperHeroi",
                columns: new[] { "Id", "Foto", "Nome", "SuperPoder" },
                values: new object[] { 2, "/images/m.jpg", "Miranha", "Soltar Teia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeroi");
        }
    }
}
