using TorneoDeFutbol.App.Dominio;
using System.Collections.Generic;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDirector
    
    {

        Director_Tecnico AddDirectorTecnico (Director_Tecnico directorTecnico);
        IEnumerable<Director_Tecnico> GetAllDirectoresTecnicos();
        Director_Tecnico UpdateDirectorTecnico(Director_Tecnico director);
        void DeleteDirectorTecnico(int idDirectorTecnico);
        Director_Tecnico GetDirectorTecnico(int idDirectorTecnico);
        public IEnumerable<Director_Tecnico> GetDTPorGenero(int genero);
        public IEnumerable<Director_Tecnico>  SearchDT(string nombre);

        }
}
