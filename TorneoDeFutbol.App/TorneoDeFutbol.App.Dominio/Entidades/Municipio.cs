using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio

{
    public class Municipio
    {
        [Key]
        public  int idMunicipio { get;set; }
        public  string Nombre { get;set; }
        
        
         }
}