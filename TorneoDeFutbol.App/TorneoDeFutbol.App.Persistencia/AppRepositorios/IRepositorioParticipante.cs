using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioParticipante
    
    {
        IEnumerable<Participante> GetAllParticipantes();
        Participante AddParticipante (Participante participante);
        Participante UpdateParticipante(Participante participante);
        void DeleteParticipante(int Id_Participante);
        Participante GetParticipante(int Id_Participante);
        
        
    }
}
