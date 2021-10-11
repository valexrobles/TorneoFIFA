using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Jugador: Participante
    {
        [Display(Name = "Numero de CAMISETA")]
        public int numCamiseta { get;set; }
        [Display(Name = "Posición en el terreno de juego")]
        public Posicion posicion { get;set; }
    }
}