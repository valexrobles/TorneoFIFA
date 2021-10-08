using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio

{
    public class Colegios
    {
        [Key]
        public int idColegio { get;set; }
        public string nombre { get;set; }
    }
}