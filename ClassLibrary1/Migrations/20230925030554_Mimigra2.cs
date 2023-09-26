using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    /// <inheritdoc />
    public partial class Mimigra2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarjeta_De_Creditos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroTarjeta = table.Column<int>(type: "int", nullable: false),
                    limiteCredito = table.Column<float>(type: "real", nullable: false),
                    saldoDisponible = table.Column<float>(type: "real", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjeta_De_Creditos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarjeta_De_Creditos");
        }
    }
}
