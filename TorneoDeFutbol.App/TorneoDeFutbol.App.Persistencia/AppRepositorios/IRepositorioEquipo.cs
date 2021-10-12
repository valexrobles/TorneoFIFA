using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioEquipo
    
    {
        Equipo AddEquipo (Equipo equipo);
        IEnumerable<Equipo> GetAllEquipos();
        void DeleteEquipo(int idEquipo);
        Equipo GetEquipo(int idEquipo);
        Equipo UpdateEquipo(Equipo equipo);
        Jugador AsignarJugador (int idEquipo, int idParticipante);
        Director_Tecnico AsignarDirectorTecnico (int idEquipo, int idDirectorTecnico);
        Municipio AsignarMunicipio (int idEquipo, int idMunicipio);
        
       

    }
}
