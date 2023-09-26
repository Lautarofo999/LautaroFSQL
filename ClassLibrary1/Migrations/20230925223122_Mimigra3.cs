using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibrary1.Migrations
{
    /// <inheritdoc />
    public partial class Mimigra3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "saldoDisponible",
                table: "Tarjeta_De_Creditos",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "limiteCredito",
                table: "Tarjeta_De_Creditos",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "saldo",
                table: "Cuenta_Bancarias",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "saldoDisponible",
                table: "Tarjeta_De_Creditos",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "limiteCredito",
                table: "Tarjeta_De_Creditos",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "saldo",
                table: "Cuenta_Bancarias",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
