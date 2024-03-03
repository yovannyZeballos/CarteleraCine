using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarteleriaCine.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaPelicula_HorarioPelicula_HorarioPeliculaId",
                table: "SalaPelicula");

            migrationBuilder.DropIndex(
                name: "IX_SalaPelicula_HorarioPeliculaId",
                table: "SalaPelicula");

            migrationBuilder.DropColumn(
                name: "HorarioPeliculaId",
                table: "SalaPelicula");

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "HorarioPelicula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPelicula_SalaId",
                table: "HorarioPelicula",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_HorarioPelicula_SalaPelicula_SalaId",
                table: "HorarioPelicula",
                column: "SalaId",
                principalTable: "SalaPelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HorarioPelicula_SalaPelicula_SalaId",
                table: "HorarioPelicula");

            migrationBuilder.DropIndex(
                name: "IX_HorarioPelicula_SalaId",
                table: "HorarioPelicula");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "HorarioPelicula");

            migrationBuilder.AddColumn<int>(
                name: "HorarioPeliculaId",
                table: "SalaPelicula",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SalaPelicula_HorarioPeliculaId",
                table: "SalaPelicula",
                column: "HorarioPeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaPelicula_HorarioPelicula_HorarioPeliculaId",
                table: "SalaPelicula",
                column: "HorarioPeliculaId",
                principalTable: "HorarioPelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
