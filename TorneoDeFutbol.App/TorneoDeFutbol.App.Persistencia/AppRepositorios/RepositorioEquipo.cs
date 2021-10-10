using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext  = new AppContext();
        
        Equipo IRepositorioEquipo.AddEquipo (Equipo equipo) 
        {
            var equipoAdicionado = _appContext.Equipos.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        } 
        
        IEnumerable<Equipo> IRepositorioEquipo.GetAllEquipos()
        {
             return _appContext.Equipos;
        }


        public void DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado == null)
                {return;}
            else
                {
                  _appContext.Equipos.Remove(equipoEncontrado);
                  _appContext.SaveChanges();   
                }
        }

        public Equipo GetEquipo(int idEquipo)
        {
            return _appContext.Equipos.Find(idEquipo);
        }
        
        Jugador IRepositorioEquipo.AsignarJugador(int idParticipante, int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            {
                var jugadorEncontrado = _appContext.Jugadores.Find(idParticipante);
                if (jugadorEncontrado != null)
                {
                    equipoEncontrado.jugador = jugadorEncontrado;
                    _appContext.SaveChanges();
                }
                return jugadorEncontrado;
            }
            return null;
        }
        Director_Tecnico IRepositorioEquipo.AsignarDirectorTecnico(int idDirectorTecnico, int idEquipo)
        {
            var directorTecnicoEncontrado = _appContext.DirectoresTecnicos.Find(idDirectorTecnico);
            if (directorTecnicoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
                if (equipoEncontrado != null)
                {
                    equipoEncontrado.directorTecnico = directorTecnicoEncontrado;
                    _appContext.SaveChanges();
                }
                return directorTecnicoEncontrado;
            }
            return null;
        }


        Municipio IRepositorioEquipo.AsignarMunicipio(int idMunicipio, int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
            if (equipoEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
                if (municipioEncontrado != null)
                {
                    equipoEncontrado.municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

        
    }
}
