using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioEquipo
    
    {
        Equipo AddEquipo (Equipo equipo);
         IEnumerable<Equipo> GetAllEquipos();
        void DeleteEquipo(int Id_Equipo);
        Equipo GetEquipo(int Id_Equipo);
        Jugador AsignarJugador (int Id_Equipo, int Id_Participante);
        Director_Tecnico AsignarDirectorTecnico (int Id_Equipo, int Id_DirectorTecnico);
        Municipio AsignarMunicipio (int Id_Equipo, int Id_Municipio);
        
       

    }
}
