using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamoxApiEntities.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Conector",
                table: "Conectores",
                newName: "Conector_");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Conector_",
                table: "Conectores",
                newName: "Conector");
        }
    }
}
