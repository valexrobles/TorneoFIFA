using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Participante
    {
    [Key]
     public int idParticipante { get;set; }
     [Required(ErrorMessage = "El numero de documento es obligatorio")]
     [StringLength(15, ErrorMessage = "Maximo 15 caracteres")]
     public string numDocumento { get;set; }
     [Required(ErrorMessage = "El nombre es obligatorio")]
     [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
     public string nombre { get;set; }
     [Required(ErrorMessage = "El apellido es obligatorio")]
     [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
     public string apellido { get;set; }     
     public string direccion { get;set; }
     public string numTelefono  { get;set; }
     public string ciudad  { get;set; }
     public Genero genero { get;set; }
     public DateTime fechaNacimiento { get;set; }
   
    }
}