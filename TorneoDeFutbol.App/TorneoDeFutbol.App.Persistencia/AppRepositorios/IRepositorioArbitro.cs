using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioArbitro
    
    {
        Arbitro AddArbitro (Arbitro arbitro);
        IEnumerable<Arbitro> GetAllArbitros();
        Arbitro UpdateArbitro(Arbitro arbitro); 
        void DeleteArbitro (int idArbitro);
        Arbitro GetArbitro(int idArbitro);
        Colegio AsignarColegio (int idParticipante, int Id_Colegio);

    }
}
