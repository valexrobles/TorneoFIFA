using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio

{
    public class Registro
    {
      [Key]
      public int idRegistro { get;set;}
     public  int partidosJugados { get;set; }
     public  int partidosGanados{ get;set; }
     public  int  partidosEmpatados { get;set; }
     public  int  golesFavor { get;set; }
     public  int  golesContra { get;set; } 
     public  int puntos { get;set; }
     }
}