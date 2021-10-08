using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq;

namespace TorneoDeFutbol.App.Persistencia

{
    //Método para Obtener Lista de Jugadores

    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext  = new AppContext();
        
        //Método para Obtener lista de Jugadores
        IEnumerable<Jugador> IRepositorioJugador.GetAllJugadores()
         {
             return _appContext.Jugadores;
         }

        //Método Añadir Jugador
        Jugador IRepositorioJugador.AddJugador (Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Jugadores.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        } 

        //Método Actualizar Jugador
        Jugador IRepositorioJugador.UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(jugador.idParticipante);
            
            if (jugadorEncontrado != null)
            {

                jugadorEncontrado.nombre = jugador.nombre;
                jugadorEncontrado.apellido = jugador.apellido;
                jugadorEncontrado.numTelefono = jugador.numTelefono;
                jugadorEncontrado.direccion = jugador.direccion;
                jugadorEncontrado.ciudad = jugador.ciudad;
                jugadorEncontrado.fechaNacimiento = jugador.fechaNacimiento;
                jugadorEncontrado.genero = jugador.genero;
                jugadorEncontrado.idParticipante = jugador.idParticipante;
                jugadorEncontrado.numDocumento = jugador.numDocumento;
                jugadorEncontrado.numCamiseta = jugador.numCamiseta;
                jugadorEncontrado.posicion = jugador.posicion;
                 _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }

        //Método para Eliminar Jugador
        void IRepositorioJugador.DeleteJugador(int idJugador)
        {
            var jugadorEncontrado = _appContext.Jugadores.Find(idJugador);
            if (jugadorEncontrado == null)
            {return;}
            else
            {
            _appContext.Jugadores.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
            }
        }
   
        public Jugador GetJugador(int numCamiseta)
        {
            return _appContext.Jugadores.Where(x=>x.numCamiseta==numCamiseta).FirstOrDefault();
        }
    }
}

