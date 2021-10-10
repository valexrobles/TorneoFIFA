using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Equipo
    {
        [Key]
        public  int idEquipo { get;set; }
        public  string nombre { get;set; }
        public Municipio municipio { get;set; }
        public Estadio estadio { get;set; }
        public Jugador jugador { get;set; }
        public Registro registro { get;set; }
        public Director_Tecnico directorTecnico { get;set; }
        public bool local { get;set; }
        public bool visitante { get;set; }     
         }
}