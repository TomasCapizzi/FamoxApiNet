using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamoxApiEntities.Migrations
{
    /// <inheritdoc />
    public partial class FamoxMig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gases");

            migrationBuilder.DropTable(
                name: "ModeloEquipoDigital");

            migrationBuilder.DropTable(
                name: "ModeloGasoterapia");

            migrationBuilder.DropTable(
                name: "Rango");

            migrationBuilder.DropTable(
                name: "ModeloAccesorio");

            migrationBuilder.AlterColumn<bool>(
                name: "MediaTension",
                table: "UnidadesDeSuministros",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Gases",
                table: "UnidadesDeSuministros",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Conectores",
                table: "UnidadesDeSuministros",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "BajaTension",
                table: "UnidadesDeSuministros",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Rangos",
                table: "Gasoterapias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Codigo",
                table: "EquiposDigitales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Uso",
                table: "EquiposDigitales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rangos",
                table: "Gasoterapias");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "EquiposDigitales");

            migrationBuilder.DropColumn(
                name: "Uso",
                table: "EquiposDigitales");

            migrationBuilder.AlterColumn<string>(
                name: "MediaTension",
                table: "UnidadesDeSuministros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Gases",
                table: "UnidadesDeSuministros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Conectores",
                table: "UnidadesDeSuministros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "BajaTension",
                table: "UnidadesDeSuministros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.CreateTable(
                name: "ModeloAccesorio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccesorioId = table.Column<int>(type: "int", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloAccesorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeloAccesorio_Accesorios_AccesorioId",
                        column: x => x.AccesorioId,
                        principalTable: "Accesorios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ModeloEquipoDigital",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipoDigitalId = table.Column<int>(type: "int", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modulos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloEquipoDigital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeloEquipoDigital_EquiposDigitales_EquipoDigitalId",
                        column: x => x.EquipoDigitalId,
                        principalTable: "EquiposDigitales",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ModeloGasoterapia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GasoterapiaId = table.Column<int>(type: "int", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rango = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloGasoterapia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeloGasoterapia_Gasoterapias_GasoterapiaId",
                        column: x => x.GasoterapiaId,
                        principalTable: "Gasoterapias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rango",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GasoterapiaId = table.Column<int>(type: "int", nullable: true),
                    Rango_ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rango", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rango_Gasoterapias_GasoterapiaId",
                        column: x => x.GasoterapiaId,
                        principalTable: "Gasoterapias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Gases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aire = table.Column<bool>(type: "bit", nullable: false),
                    Co2 = table.Column<bool>(type: "bit", nullable: false),
                    Evac = table.Column<bool>(type: "bit", nullable: false),
                    Iaire = table.Column<bool>(type: "bit", nullable: false),
                    ModeloAccesorioId = table.Column<int>(type: "int", nullable: true),
                    N2 = table.Column<bool>(type: "bit", nullable: false),
                    N2o = table.Column<bool>(type: "bit", nullable: false),
                    O2 = table.Column<bool>(type: "bit", nullable: false),
                    Vacio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gases_ModeloAccesorio_ModeloAccesorioId",
                        column: x => x.ModeloAccesorioId,
                        principalTable: "ModeloAccesorio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gases_ModeloAccesorioId",
                table: "Gases",
                column: "ModeloAccesorioId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloAccesorio_AccesorioId",
                table: "ModeloAccesorio",
                column: "AccesorioId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloEquipoDigital_EquipoDigitalId",
                table: "ModeloEquipoDigital",
                column: "EquipoDigitalId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloGasoterapia_GasoterapiaId",
                table: "ModeloGasoterapia",
                column: "GasoterapiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rango_GasoterapiaId",
                table: "Rango",
                column: "GasoterapiaId");
        }
    }
}
