using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    public partial class Octubre_08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colegios",
                columns: table => new
                {
                    idColegio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colegios", x => x.idColegio);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    idMunicipio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.idMunicipio);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    idRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partidosJugados = table.Column<int>(type: "int", nullable: false),
                    partidosGanados = table.Column<int>(type: "int", nullable: false),
                    partidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    golesFavor = table.Column<int>(type: "int", nullable: false),
                    golesContra = table.Column<int>(type: "int", nullable: false),
                    puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.idRegistro);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    idParticipante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    genero = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    arbitroFIFA = table.Column<bool>(type: "bit", nullable: true),
                    fechaAfiliacionFIFA = table.Column<DateTime>(type: "datetime2", nullable: true),
                    colegioidColegio = table.Column<int>(type: "int", nullable: true),
                    aniosExperiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numCamiseta = table.Column<int>(type: "int", nullable: true),
                    posicion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.idParticipante);
                    table.ForeignKey(
                        name: "FK_Participantes_Colegios_colegioidColegio",
                        column: x => x.colegioidColegio,
                        principalTable: "Colegios",
                        principalColumn: "idColegio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadios",
                columns: table => new
                {
                    idEstadio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacidadEspectadores = table.Column<int>(type: "int", nullable: false),
                    municipioidMunicipio = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadios", x => x.idEstadio);
                    table.ForeignKey(
                        name: "FK_Estadios_Municipios_municipioidMunicipio",
                        column: x => x.municipioidMunicipio,
                        principalTable: "Municipios",
                        principalColumn: "idMunicipio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    idEquipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    municipioidMunicipio = table.Column<int>(type: "int", nullable: true),
                    estadioidEstadio = table.Column<int>(type: "int", nullable: true),
                    jugadoridParticipante = table.Column<int>(type: "int", nullable: true),
                    registroidRegistro = table.Column<int>(type: "int", nullable: true),
                    directorTecnicoidParticipante = table.Column<int>(type: "int", nullable: true),
                    local = table.Column<bool>(type: "bit", nullable: false),
                    visitante = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.idEquipo);
                    table.ForeignKey(
                        name: "FK_Equipos_Estadios_estadioidEstadio",
                        column: x => x.estadioidEstadio,
                        principalTable: "Estadios",
                        principalColumn: "idEstadio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Municipios_municipioidMunicipio",
                        column: x => x.municipioidMunicipio,
                        principalTable: "Municipios",
                        principalColumn: "idMunicipio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Participantes_directorTecnicoidParticipante",
                        column: x => x.directorTecnicoidParticipante,
                        principalTable: "Participantes",
                        principalColumn: "idParticipante",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Participantes_jugadoridParticipante",
                        column: x => x.jugadoridParticipante,
                        principalTable: "Participantes",
                        principalColumn: "idParticipante",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Registros_registroidRegistro",
                        column: x => x.registroidRegistro,
                        principalTable: "Registros",
                        principalColumn: "idRegistro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatosPartidos",
                columns: table => new
                {
                    idDatosPartido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marcador = table.Column<int>(type: "int", nullable: false),
                    tarjetasAmarillas = table.Column<int>(type: "int", nullable: false),
                    tarjetasRojas = table.Column<int>(type: "int", nullable: false),
                    golesV = table.Column<int>(type: "int", nullable: false),
                    golesL = table.Column<int>(type: "int", nullable: false),
                    tiempo = table.Column<int>(type: "int", nullable: false),
                    equipoidEquipo = table.Column<int>(type: "int", nullable: true),
                    arbitroidParticipante = table.Column<int>(type: "int", nullable: true),
                    estadioidEstadio = table.Column<int>(type: "int", nullable: true),
                    equipoLocal = table.Column<bool>(type: "bit", nullable: false),
                    equipoVisitante = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPartidos", x => x.idDatosPartido);
                    table.ForeignKey(
                        name: "FK_DatosPartidos_Equipos_equipoidEquipo",
                        column: x => x.equipoidEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosPartidos_Estadios_estadioidEstadio",
                        column: x => x.estadioidEstadio,
                        principalTable: "Estadios",
                        principalColumn: "idEstadio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DatosPartidos_Participantes_arbitroidParticipante",
                        column: x => x.arbitroidParticipante,
                        principalTable: "Participantes",
                        principalColumn: "idParticipante",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partidos",
                columns: table => new
                {
                    idPartido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    equipoVisitante = table.Column<bool>(type: "bit", nullable: false),
                    equipoLocal = table.Column<bool>(type: "bit", nullable: false),
                    golesLocal = table.Column<int>(type: "int", nullable: false),
                    golesVisitante = table.Column<int>(type: "int", nullable: false),
                    marcador = table.Column<int>(type: "int", nullable: false),
                    estadioidEstadio = table.Column<int>(type: "int", nullable: true),
                    equipoidEquipo = table.Column<int>(type: "int", nullable: true),
                    datosPartidoidDatosPartido = table.Column<int>(type: "int", nullable: true),
                    arbitroidParticipante = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partidos", x => x.idPartido);
                    table.ForeignKey(
                        name: "FK_Partidos_DatosPartidos_datosPartidoidDatosPartido",
                        column: x => x.datosPartidoidDatosPartido,
                        principalTable: "DatosPartidos",
                        principalColumn: "idDatosPartido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Equipos_equipoidEquipo",
                        column: x => x.equipoidEquipo,
                        principalTable: "Equipos",
                        principalColumn: "idEquipo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Estadios_estadioidEstadio",
                        column: x => x.estadioidEstadio,
                        principalTable: "Estadios",
                        principalColumn: "idEstadio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partidos_Participantes_arbitroidParticipante",
                        column: x => x.arbitroidParticipante,
                        principalTable: "Participantes",
                        principalColumn: "idParticipante",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatosPartidos_arbitroidParticipante",
                table: "DatosPartidos",
                column: "arbitroidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPartidos_equipoidEquipo",
                table: "DatosPartidos",
                column: "equipoidEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_DatosPartidos_estadioidEstadio",
                table: "DatosPartidos",
                column: "estadioidEstadio");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_directorTecnicoidParticipante",
                table: "Equipos",
                column: "directorTecnicoidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_estadioidEstadio",
                table: "Equipos",
                column: "estadioidEstadio");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_jugadoridParticipante",
                table: "Equipos",
                column: "jugadoridParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_municipioidMunicipio",
                table: "Equipos",
                column: "municipioidMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_registroidRegistro",
                table: "Equipos",
                column: "registroidRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_Estadios_municipioidMunicipio",
                table: "Estadios",
                column: "municipioidMunicipio");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_colegioidColegio",
                table: "Participantes",
                column: "colegioidColegio");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_arbitroidParticipante",
                table: "Partidos",
                column: "arbitroidParticipante");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_datosPartidoidDatosPartido",
                table: "Partidos",
                column: "datosPartidoidDatosPartido");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_equipoidEquipo",
                table: "Partidos",
                column: "equipoidEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Partidos_estadioidEstadio",
                table: "Partidos",
                column: "estadioidEstadio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partidos");

            migrationBuilder.DropTable(
                name: "DatosPartidos");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Estadios");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "Registros");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "Colegios");
        }
    }
}
