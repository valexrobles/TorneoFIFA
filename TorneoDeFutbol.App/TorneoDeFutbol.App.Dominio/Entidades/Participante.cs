using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Participante
    {
    [Key]
     public int idParticipante { get;set; }
     [Display(Name = "Número Identificación Personal")]
     public string numDocumento { get;set; }
     [Display(Name = "Nombres")]
     public string nombre { get;set; }
     [Display(Name = "Apellidos")]
     public string apellido { get;set; }     
     [Display(Name = "Dirección")]
     public string direccion { get;set; }
     [Display(Name = "Número de Teléfono")]
     public string numTelefono  { get;set; }
     [Display(Name = "Ciudad")]
     public string ciudad  { get;set; }
     [Display(Name = "Género")]
     public Genero genero { get;set; }
     [Display(Name = "Fecha de nacimiento")]
     public DateTime fechaNacimiento { get;set; }
   
    }
}