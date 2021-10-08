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
            var directorEncontrado = _appContext.DirectoresTecnicos.Find(director.idParticipante);
            
            if (directorEncontrado != null)
            {
                directorEncontrado.nombre = director.nombre;
                directorEncontrado.apellido = director.apellido;
                directorEncontrado.numeroTelefono = director.numeroTelefono;
                directorEncontrado.direccion = director.direccion;
                directorEncontrado.ciudad = director.ciudad;
                directorEncontrado.fechaNacimiento = director.fechaNacimiento;
                directorEncontrado.genero = director.genero;
                directorEncontrado.idParticipante = director.idParticipante;
                directorEncontrado.numeroDocumento = director.numeroDocumento;
                directorEncontrado.aniosExperiencia = director.aniosExperiencia;
                 _appContext.SaveChanges();
            }
            return directorEncontrado;
        }

         //Método para Eliminar Director Técnico
        public void DeleteDirectorTecnico(int Id_DirectorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(Id_DirectorTecnico);
            if (directorTecnicoEncontrado == null)
                return;
            _appContext.DirectoresTecnicos.Remove(directorTecnicoEncontrado);
            _appContext.SaveChanges();
         }

        //Método para Obtener un Director_Técnico
        public Director_Tecnico GetDirectorTecnico(int Id_DirectorTecnico)
        {
            return _appContext.DirectoresTecnicos.Find(Id_DirectorTecnico);
        }
                

    }
}
