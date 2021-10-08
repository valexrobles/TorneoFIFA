using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoDeFutbol.App.Dominio

{
    public class Partido
    {
        [Key]
     public   int idPartido { get;set; }
     public   DateTime fecha { get;set; }
     public   DateTime hora { get;set; }
     public   bool equipoVisitante { get;set; }
     public   bool equipoLocal { get;set; }
     public   int golesLocal { get;set; }
     public   int golesVisitante { get;set; }
     public   int marcador { get;set; }
     public   Estadio estadio { get;set; }
     public   Equipo equipo  { get;set; }
     public   Datos_Partido datosPartido  { get;set; }
     public   Arbitro arbitro  { get;set; }
     
     }
}