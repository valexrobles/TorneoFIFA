using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio

{
    public class Municipio
    {
        [Key]
        public  int Id { get;set; }
        public  string Nombre { get;set; }
        
        
         }
}