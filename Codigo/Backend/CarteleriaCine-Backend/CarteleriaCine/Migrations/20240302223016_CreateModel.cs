using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarteleriaCine.Migrations
{
    /// <inheritdoc />
    public partial class CreateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "Pelicula");

            migrationBuilder.CreateTable(
                name: "HorarioPelicula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateOnly>(type: "Date", nullable: false),
                    HoraInicio = table.Column<string>(type: "char(5)", nullable: false),
                    HoraFin = table.Column<string>(type: "char(5)", nullable: false),
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioPelicula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorarioPelicula_Pelicula_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Pelicula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoIdentidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentoIdentidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaPelicula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    EntradasDisponibles = table.Column<int>(type: "int", nullable: false),
                    HorarioPeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaPelicula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaPelicula_HorarioPelicula_HorarioPeliculaId",
                        column: x => x.HorarioPeliculaId,
                        principalTable: "HorarioPelicula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "varchar(30)", nullable: false),
                    ApeliidoPaterno = table.Column<string>(type: "varchar(30)", nullable: false),
                    ApeliidoMaterno = table.Column<string>(type: "varchar(30)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "varchar(20)", nullable: false),
                    Genero = table.Column<string>(type: "char(1)", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "Date", nullable: false),
                    TipoDocumentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_TipoDocumentoIdentidad_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentoIdentidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservaPelicula",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    SalaPeliculaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservaPelicula", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservaPelicula_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservaPelicula_SalaPelicula_SalaPeliculaId",
                        column: x => x.SalaPeliculaId,
                        principalTable: "SalaPelicula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_TipoDocumentoId",
                table: "Cliente",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_HorarioPelicula_PeliculaId",
                table: "HorarioPelicula",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaPelicula_ClienteId",
                table: "ReservaPelicula",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservaPelicula_SalaPeliculaId",
                table: "ReservaPelicula",
                column: "SalaPeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaPelicula_HorarioPeliculaId",
                table: "SalaPelicula",
                column: "HorarioPeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservaPelicula");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "SalaPelicula");

            migrationBuilder.DropTable(
                name: "TipoDocumentoIdentidad");

            migrationBuilder.DropTable(
                name: "HorarioPelicula");

            migrationBuilder.AddColumn<string>(
                name: "HoraInicio",
                table: "Pelicula",
                type: "char(5)",
                nullable: true);
        }
    }
}
