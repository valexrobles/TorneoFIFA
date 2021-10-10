using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDirector
    
    {

        Director_Tecnico AddDirectorTecnico (Director_Tecnico directorTecnico);
        IEnumerable<Director_Tecnico> GetAllDirectoresTecnicos();
        Director_Tecnico UpdateDirectorTecnico(Director_Tecnico director);
        void DeleteDirectorTecnico(int Id_DirectorTecnico);
        Director_Tecnico GetDirectorTecnico(int Id_DirectorTecnico);
        }
}
