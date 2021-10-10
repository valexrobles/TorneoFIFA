using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Datos_Partido
    {
        [Key]
     public  int idDatosPartido { get;set; }
     public  int marcador { get;set; }
     public  int tarjetasAmarillas{ get;set; }
     public  int tarjetasRojas { get;set; }
     public  int golesV { get;set; }
     public  int golesL { get;set; }
     public  int tiempo { get;set; }
     public  Equipo equipo { get;set; }
     public  Arbitro arbitro { get;set;}
     public  Estadio estadio { get;set;}
     public  bool equipoLocal {get;set; }
     public  bool equipoVisitante {get;set; }
     
          
     
    }
}