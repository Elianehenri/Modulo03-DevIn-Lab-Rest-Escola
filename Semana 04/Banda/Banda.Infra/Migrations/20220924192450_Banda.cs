using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banda.Infra.Migrations
{
    public partial class Banda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TOCAR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRICAO = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: false),
                    NOME_MUSICA = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    SEQUENCIA_MUSICA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TOCAR", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TOCAR");
        }
    }
}
