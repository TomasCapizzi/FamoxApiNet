using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamoxApiEntities.Migrations
{
    /// <inheritdoc />
    public partial class FamoxMig42 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Iluminacion",
                table: "UnidadesDeSuministros",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "BajaTensiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BajaTension_ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BajaTensiones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conectores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conector = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conectores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Iluminaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iluminacion_ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iluminaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaTensiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaTension_ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTensiones", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BajaTensiones");

            migrationBuilder.DropTable(
                name: "Conectores");

            migrationBuilder.DropTable(
                name: "Iluminaciones");

            migrationBuilder.DropTable(
                name: "MediaTensiones");

            migrationBuilder.DropColumn(
                name: "Iluminacion",
                table: "UnidadesDeSuministros");
        }
    }
}
