using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrantHack38.App.Persistencia.Migrations
{
    public partial class camioNombreVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombres",
                table: "Migrantes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "DirecciónActual",
                table: "Migrantes",
                newName: "DireccionActual");

            migrationBuilder.RenameColumn(
                name: "Apellidos",
                table: "Migrantes",
                newName: "Apellido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Migrantes",
                newName: "Nombres");

            migrationBuilder.RenameColumn(
                name: "DireccionActual",
                table: "Migrantes",
                newName: "DirecciónActual");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Migrantes",
                newName: "Apellidos");
        }
    }
}
