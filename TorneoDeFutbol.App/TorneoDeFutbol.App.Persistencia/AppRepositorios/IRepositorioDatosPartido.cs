using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDatosPartido
    
    {
        
        Datos_Partido AddDatosPartido (Datos_Partido datosPartido);
        IEnumerable<Datos_Partido> GetAllDatosPartidos();
        void DeleteDatosPartido(int idDatosPartido);
        Equipo GetEquipoVisitante (int idEquipo);
        Equipo GetEquipoLocal (int idEquipo);
        Arbitro AsignarArbitro (int idDatosPartido, int idArbitro);
        Estadio AsignarEstadio (int idDatosPartido, int idEstadio);
        Equipo AsignarEquipoVisitante (int idDatosPartido, int idEquipo);
        Equipo AsignarEquipoLocal (int idDatosPartido , int idEquipo);
        Datos_Partido GetDatosPartido(int idDatosPartido);

    }
}
