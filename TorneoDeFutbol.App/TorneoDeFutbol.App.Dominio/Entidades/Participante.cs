using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Participante
    {
    [Key]
     public int idParticipante { get;set; }
     public string numeroDocumento { get;set; }
     public string nombre { get;set; }
     public string apellido { get;set; }     
     public string direccion { get;set; }
     public string numeroTelefono  { get;set; }
     public string ciudad  { get;set; }
     public Genero genero { get;set; }
     public DateTime fechaNacimiento { get;set; }
   
    }
}