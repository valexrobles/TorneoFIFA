using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioDirector : IRepositorioDirector
    {
        private readonly AppContext _appContext = new AppContext();

        //Método para Obtener Lista de Directores Técnicos
        IEnumerable<Director_Tecnico> IRepositorioDirector.GetAllDirectoresTecnicos()
         {
             return _appContext.DirectoresTecnicos;
         }

         //Método para Añadir Director Técnico
        Director_Tecnico IRepositorioDirector.AddDirectorTecnico (Director_Tecnico director) 
        {
            var directorAdicionado = _appContext.DirectoresTecnicos.Add(director);
            _appContext.SaveChanges();
            return directorAdicionado.Entity;
        } 


        //Método para Actualizar Director_Tecnico
        Director_Tecnico IRepositorioDirector.UpdateDirectorTecnico(Director_Tecnico director)
        {
            var director_tecnicoEncontrado = _appContext.DirectoresTecnicos.Find(director.idParticipante);
            
            if (director_tecnicoEncontrado != null)
            {
                director_tecnicoEncontrado.nombre = director.nombre;
                director_tecnicoEncontrado.apellido = director.apellido;
                director_tecnicoEncontrado.numTelefono = director.numTelefono;
                director_tecnicoEncontrado.direccion = director.direccion;
                director_tecnicoEncontrado.ciudad = director.ciudad;
                director_tecnicoEncontrado.fechaNacimiento = director.fechaNacimiento;
                director_tecnicoEncontrado.genero = director.genero;
                director_tecnicoEncontrado.numDocumento = director.numDocumento;
                director_tecnicoEncontrado.aniosExperiencia = director.aniosExperiencia;
                 _appContext.SaveChanges();
            }
            return director_tecnicoEncontrado;
        }

         //Método para Eliminar Director Técnico
        public void DeleteDirectorTecnico(int Id_DirectorTecnico)
        {
            var director_tecnicoEncontrado = _appContext.DirectoresTecnicos.Find(Id_DirectorTecnico);
            if (director_tecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(director_tecnicoEncontrado);
            _appContext.SaveChanges();
         }

        //Método para Obtener un Director_Técnico
        public Director_Tecnico GetDirectorTecnico(int Id_DirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.Find(Id_DirectorTecnico);
        }
                

    }
}
