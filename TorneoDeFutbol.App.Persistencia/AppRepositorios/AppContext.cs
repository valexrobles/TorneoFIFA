using Microsoft.EntityFrameworkCore;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Participante> Participantes {get;set;}
        public DbSet<Arbitro> Arbitros {get;set;}
        public DbSet<Director_Tecnico> DirectoresTecnicos {get;set;}
        public DbSet<Datos_Partido> DatosPartidos {get;set;}
        public DbSet<Equipo> Equipos {get;set;}
        public DbSet<Estadio> Estadios {get;set;}
        public DbSet<Jugador> Jugadores {get;set;}
        public DbSet<Municipio> Municipios {get;set;}
        public DbSet<Partido> Partidos {get;set;}
        public DbSet<Registro> Registros {get;set;}
        public DbSet<Colegio> Colegios {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=TorneoDeFutbolData");
            }
        }
    }
}