using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioJugador
    
    {
        Jugador AddJugador (Jugador jugador);
        IEnumerable<Jugador> GetAllJugadores();
        Jugador UpdateJugador(Jugador jugador);
        void DeleteJugador(int idJugador);
        Jugador GetJugador(int idJugador);
    }
        
}
