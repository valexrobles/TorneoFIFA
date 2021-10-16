using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioArbitro
    
    {
        Arbitro AddArbitro (Arbitro arbitro);
        IEnumerable<Arbitro> GetAllArbitros();
        Arbitro UpdateArbitro(Arbitro arbitro); 
        void DeleteArbitro (int idParticipante);
        Arbitro GetArbitro(int idParticipante);
        Colegio AsignarColegio (int idParticipante, int idColegio);

    }
}
