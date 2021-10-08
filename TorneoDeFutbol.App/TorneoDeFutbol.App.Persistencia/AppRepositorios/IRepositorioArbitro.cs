using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioArbitro
    
    {
        Arbitro AddArbitro (Arbitro arbitro);
        IEnumerable<Arbitro> GetAllArbitros();
        void DeleteArbitro (int Id_Arbitro);
        Arbitro GetArbitro(int Id_Arbitro);
        Colegio AsignarColegio (int Id_Arbitro, int Id_Colegio);

    }
}
