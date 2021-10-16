using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        Estadio AddEstadio (Estadio estadio);
        IEnumerable<Estadio> GetAllEstadios();
        void DeleteEstadio(int Id_Estadio);
        Estadio GetEstadio (int Id_Estadio);
        Estadio UpdateEstadio(Estadio estadio);
        Municipio AsignarMunicipio (int Id_Estadio, int Id_Municipio);
        IEnumerable<Estadio> SearchEstadios(string nombre);
    }
}
