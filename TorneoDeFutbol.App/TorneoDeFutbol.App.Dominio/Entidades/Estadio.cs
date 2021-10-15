using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio

{
    public class Estadio
    {
        [Key]
        public int idEstadio { get;set; }
        [Required(ErrorMessage = "¡El Nombre es Obligatorio!")]
        [Display(Name = "Nombre")]
        public string nombre { get;set; }
        [Display(Name = "Dirección")]
        public string direccion { get;set; }
        [Display(Name = "Capacidad de Espectadores")]
        public int capacidadEspectadores { get;set;}
        public Municipio municipio  { get;set; }
        
   
    }
}