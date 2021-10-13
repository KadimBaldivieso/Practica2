using Microsoft.EntityFrameworkCore.Migrations;

namespace CancionesWebApi2.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cancion",
                columns: table => new
                {
                    Autor = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Letra = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Enlace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancion", x => x.Autor);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cancion");
        }
    }
}
