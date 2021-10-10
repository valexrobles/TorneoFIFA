using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio

{
    public class Estadio
    {
        [Key]
        public  int idEstadio { get;set; }
        public  string nombre { get;set; }
        public  string direccion { get;set; }
        public int capacidadEspectadores { get;set;}
        public  Municipio municipio  { get;set; }
        
   
         }
}