using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamoxApiEntities.Migrations
{
    /// <inheritdoc />
    public partial class FamoxMigracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accesorios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accesorio_ = table.Column<bool>(type: "bit", nullable: false),
                    Manual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gases = table.Column<bool>(type: "bit", nullable: false),
                    AccesorioUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesorios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquiposDigitales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anmat = table.Column<bool>(type: "bit", nullable: false),
                    Manual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelos = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipoDigital_ = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquiposDigitales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gasoterapias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rango = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anmat = table.Column<bool>(type: "bit", nullable: false),
                    Manual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conexion = table.Column<bool>(type: "bit", nullable: false),
                    Gas = table.Column<bool>(type: "bit", nullable: false),
                    Modelos = table.Column<bool>(type: "bit", nullable: false),
                    Gasoterapia_ = table.Column<bool>(type: "bit", nullable: false),
                    Conectores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gases_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gasoterapias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Obra_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instalacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesDeSuministros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anmat = table.Column<bool>(type: "bit", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conexion = table.Column<bool>(type: "bit", nullable: false),
                    Gas = table.Column<bool>(type: "bit", nullable: false),
                    Modelos = table.Column<bool>(type: "bit", nullable: false),
                    Gasoterapia = table.Column<bool>(type: "bit", nullable: false),
                    MediaTension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BajaTension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conectores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gases = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    Manual = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesDeSuministros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeloAccesorio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccesorioId = table.Column<int>(type: "int", nullable: true)
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
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modulos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipoDigitalId = table.Column<int>(type: "int", nullable: true)
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
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rango = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasoterapiaId = table.Column<int>(type: "int", nullable: true)
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
                    Rango_ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasoterapiaId = table.Column<int>(type: "int", nullable: true)
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
                    O2 = table.Column<bool>(type: "bit", nullable: false),
                    Aire = table.Column<bool>(type: "bit", nullable: false),
                    Vacio = table.Column<bool>(type: "bit", nullable: false),
                    N2o = table.Column<bool>(type: "bit", nullable: false),
                    N2 = table.Column<bool>(type: "bit", nullable: false),
                    Co2 = table.Column<bool>(type: "bit", nullable: false),
                    Iaire = table.Column<bool>(type: "bit", nullable: false),
                    Evac = table.Column<bool>(type: "bit", nullable: false),
                    ModeloAccesorioId = table.Column<int>(type: "int", nullable: true)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gases");

            migrationBuilder.DropTable(
                name: "ModeloEquipoDigital");

            migrationBuilder.DropTable(
                name: "ModeloGasoterapia");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Rango");

            migrationBuilder.DropTable(
                name: "UnidadesDeSuministros");

            migrationBuilder.DropTable(
                name: "ModeloAccesorio");

            migrationBuilder.DropTable(
                name: "EquiposDigitales");

            migrationBuilder.DropTable(
                name: "Gasoterapias");

            migrationBuilder.DropTable(
                name: "Accesorios");
        }
    }
}
