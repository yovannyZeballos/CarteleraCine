using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarteleriaCine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaPelicula_SalaPelicula_SalaPeliculaId",
                table: "ReservaPelicula");

            migrationBuilder.RenameColumn(
                name: "SalaPeliculaId",
                table: "ReservaPelicula",
                newName: "HorarioPeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservaPelicula_SalaPeliculaId",
                table: "ReservaPelicula",
                newName: "IX_ReservaPelicula_HorarioPeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaPelicula_HorarioPelicula_HorarioPeliculaId",
                table: "ReservaPelicula",
                column: "HorarioPeliculaId",
                principalTable: "HorarioPelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservaPelicula_HorarioPelicula_HorarioPeliculaId",
                table: "ReservaPelicula");

            migrationBuilder.RenameColumn(
                name: "HorarioPeliculaId",
                table: "ReservaPelicula",
                newName: "SalaPeliculaId");

            migrationBuilder.RenameIndex(
                name: "IX_ReservaPelicula_HorarioPeliculaId",
                table: "ReservaPelicula",
                newName: "IX_ReservaPelicula_SalaPeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservaPelicula_SalaPelicula_SalaPeliculaId",
                table: "ReservaPelicula",
                column: "SalaPeliculaId",
                principalTable: "SalaPelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
