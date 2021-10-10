﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211009015555_Octubre_08")]
    partial class Octubre_08
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Colegio", b =>
                {
                    b.Property<int>("idColegio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idColegio");

                    b.ToTable("Colegios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Datos_Partido", b =>
                {
                    b.Property<int>("idDatosPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("arbitroidParticipante")
                        .HasColumnType("int");

                    b.Property<bool>("equipoLocal")
                        .HasColumnType("bit");

                    b.Property<bool>("equipoVisitante")
                        .HasColumnType("bit");

                    b.Property<int?>("equipoidEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("estadioidEstadio")
                        .HasColumnType("int");

                    b.Property<int>("golesL")
                        .HasColumnType("int");

                    b.Property<int>("golesV")
                        .HasColumnType("int");

                    b.Property<int>("marcador")
                        .HasColumnType("int");

                    b.Property<int>("tarjetasAmarillas")
                        .HasColumnType("int");

                    b.Property<int>("tarjetasRojas")
                        .HasColumnType("int");

                    b.Property<int>("tiempo")
                        .HasColumnType("int");

                    b.HasKey("idDatosPartido");

                    b.HasIndex("arbitroidParticipante");

                    b.HasIndex("equipoidEquipo");

                    b.HasIndex("estadioidEstadio");

                    b.ToTable("DatosPartidos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("idEquipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("directorTecnicoidParticipante")
                        .HasColumnType("int");

                    b.Property<int?>("estadioidEstadio")
                        .HasColumnType("int");

                    b.Property<int?>("jugadoridParticipante")
                        .HasColumnType("int");

                    b.Property<bool>("local")
                        .HasColumnType("bit");

                    b.Property<int?>("municipioidMunicipio")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("registroidRegistro")
                        .HasColumnType("int");

                    b.Property<bool>("visitante")
                        .HasColumnType("bit");

                    b.HasKey("idEquipo");

                    b.HasIndex("directorTecnicoidParticipante");

                    b.HasIndex("estadioidEstadio");

                    b.HasIndex("jugadoridParticipante");

                    b.HasIndex("municipioidMunicipio");

                    b.HasIndex("registroidRegistro");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.Property<int>("idEstadio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("capacidadEspectadores")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("municipioidMunicipio")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEstadio");

                    b.HasIndex("municipioidMunicipio");

                    b.ToTable("Estadios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Municipio", b =>
                {
                    b.Property<int>("idMunicipio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMunicipio");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Participante", b =>
                {
                    b.Property<int>("idParticipante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numDocumento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idParticipante");

                    b.ToTable("Participantes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Participante");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.Property<int>("idPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("arbitroidParticipante")
                        .HasColumnType("int");

                    b.Property<int?>("datosPartidoidDatosPartido")
                        .HasColumnType("int");

                    b.Property<bool>("equipoLocal")
                        .HasColumnType("bit");

                    b.Property<bool>("equipoVisitante")
                        .HasColumnType("bit");

                    b.Property<int?>("equipoidEquipo")
                        .HasColumnType("int");

                    b.Property<int?>("estadioidEstadio")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("golesLocal")
                        .HasColumnType("int");

                    b.Property<int>("golesVisitante")
                        .HasColumnType("int");

                    b.Property<DateTime>("hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("marcador")
                        .HasColumnType("int");

                    b.HasKey("idPartido");

                    b.HasIndex("arbitroidParticipante");

                    b.HasIndex("datosPartidoidDatosPartido");

                    b.HasIndex("equipoidEquipo");

                    b.HasIndex("estadioidEstadio");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Registro", b =>
                {
                    b.Property<int>("idRegistro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("golesContra")
                        .HasColumnType("int");

                    b.Property<int>("golesFavor")
                        .HasColumnType("int");

                    b.Property<int>("partidosEmpatados")
                        .HasColumnType("int");

                    b.Property<int>("partidosGanados")
                        .HasColumnType("int");

                    b.Property<int>("partidosJugados")
                        .HasColumnType("int");

                    b.Property<int>("puntos")
                        .HasColumnType("int");

                    b.HasKey("idRegistro");

                    b.ToTable("Registros");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Participante");

                    b.Property<bool>("arbitroFIFA")
                        .HasColumnType("bit");

                    b.Property<int?>("colegioidColegio")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaAfiliacionFIFA")
                        .HasColumnType("datetime2");

                    b.HasIndex("colegioidColegio");

                    b.HasDiscriminator().HasValue("Arbitro");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Director_Tecnico", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Participante");

                    b.Property<string>("aniosExperiencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Director_Tecnico");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Jugador", b =>
                {
                    b.HasBaseType("TorneoDeFutbol.App.Dominio.Participante");

                    b.Property<int>("numCamiseta")
                        .HasColumnType("int");

                    b.Property<int>("posicion")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Jugador");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Datos_Partido", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroidParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoidEquipo");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioidEstadio");

                    b.Navigation("arbitro");

                    b.Navigation("equipo");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Equipo", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Director_Tecnico", "directorTecnico")
                        .WithMany()
                        .HasForeignKey("directorTecnicoidParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioidEstadio");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Jugador", "jugador")
                        .WithMany()
                        .HasForeignKey("jugadoridParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "municipio")
                        .WithMany()
                        .HasForeignKey("municipioidMunicipio");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Registro", "registro")
                        .WithMany()
                        .HasForeignKey("registroidRegistro");

                    b.Navigation("directorTecnico");

                    b.Navigation("estadio");

                    b.Navigation("jugador");

                    b.Navigation("municipio");

                    b.Navigation("registro");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Estadio", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Municipio", "municipio")
                        .WithMany()
                        .HasForeignKey("municipioidMunicipio");

                    b.Navigation("municipio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Partido", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroidParticipante");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Datos_Partido", "datosPartido")
                        .WithMany()
                        .HasForeignKey("datosPartidoidDatosPartido");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoidEquipo");

                    b.HasOne("TorneoDeFutbol.App.Dominio.Estadio", "estadio")
                        .WithMany()
                        .HasForeignKey("estadioidEstadio");

                    b.Navigation("arbitro");

                    b.Navigation("datosPartido");

                    b.Navigation("equipo");

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("TorneoDeFutbol.App.Dominio.Arbitro", b =>
                {
                    b.HasOne("TorneoDeFutbol.App.Dominio.Colegio", "colegio")
                        .WithMany()
                        .HasForeignKey("colegioidColegio");

                    b.Navigation("colegio");
                });
#pragma warning restore 612, 618
        }
    }
}
