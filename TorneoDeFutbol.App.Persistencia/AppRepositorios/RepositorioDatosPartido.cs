using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioDatosPartido : IRepositorioDatosPartido
    {
        private readonly AppContext _appContext = new AppContext();
        

        Datos_Partido IRepositorioDatosPartido.AddDatosPartido (Datos_Partido datosPartido) 
        {
            var datosPartidoAdicionado = _appContext.DatosPartidos.Add(datosPartido);
            _appContext.SaveChanges();
            return datosPartidoAdicionado.Entity;
        } 


         IEnumerable<Datos_Partido> IRepositorioDatosPartido.GetAllDatosPartidos()
         {
             return _appContext.DatosPartidos;
         }


        public void DeleteDatosPartido(int Id_DatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartidos.Find(Id_DatosPartido);
            if (datosPartidoEncontrado == null)
                return;
            _appContext.DatosPartidos.Remove(datosPartidoEncontrado);
            _appContext.SaveChanges();
         }

        /*Datos_Partido GetDatosPartido(int Id_DatosPartido)
        {
            return _appContext.DatosPartido.Find(Id_DatosPartido);
        }*/
        
        Arbitro IRepositorioDatosPartido.AsignarArbitro(int idArbitro, int idDatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartidos.Find(idDatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
                if (arbitroEncontrado != null)
                {
                    datosPartidoEncontrado.arbitro = arbitroEncontrado;
                    _appContext.SaveChanges();
                }
                return arbitroEncontrado;
            }
            return null;
        }

        Estadio IRepositorioDatosPartido.AsignarEstadio(int idEstadio, int idDatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartidos.Find(idDatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
                if (estadioEncontrado != null)
                {
                    datosPartidoEncontrado.estadio = estadioEncontrado;
                    _appContext.SaveChanges();
                }
                return estadioEncontrado;
            }
            return null;
        }

        Equipo IRepositorioDatosPartido.AsignarEquipoLocal(int idEquipo, int idDatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartidos.Find(idDatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
                if (equipoEncontrado != null)
                {
                    datosPartidoEncontrado.equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        Equipo IRepositorioDatosPartido.AsignarEquipoVisitante(int idEquipo, int idDatosPartido)
        {
            var datosPartidoEncontrado = _appContext.DatosPartidos.Find(idDatosPartido);
            if (datosPartidoEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipos.Find(idEquipo);
                if (equipoEncontrado != null)
                {
                    datosPartidoEncontrado.equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }

        //Metodos con implementacion por descarte!!!!
        Equipo IRepositorioDatosPartido.GetEquipoVisitante (int idEquipo)
        {
           Equipo equipoVisitante = new Equipo();
           return equipoVisitante; 
        }
        Equipo IRepositorioDatosPartido.GetEquipoLocal (int idEquipo)
        {
            Equipo equipoLocal = new Equipo();
            return equipoLocal;
        }

    }
}
