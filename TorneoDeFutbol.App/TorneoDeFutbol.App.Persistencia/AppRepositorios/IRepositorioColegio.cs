using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioColegio
    
    {
        Colegio AddColegio (Colegio colegio);
        IEnumerable<Colegio> GetAllColegios();
        void DeleteColegio(int Id_Colegio);
        Colegio GetColegio(int Id_Colegio);
    }
}
