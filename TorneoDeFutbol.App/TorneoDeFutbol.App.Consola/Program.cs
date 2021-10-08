using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Consola
{    class Program
    {
        private static IRepositorioParticipante _repoParticipante = new RepositorioParticipante();
        private static IRepositorioJugador _repoJugador = new RepositorioJugador();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioDirector _repoDirector = new RepositorioDirector();
        private static IRepositorioColegio _repoColegio = new RepositorioColegio(); 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework");
            //BuscarParticipante();
            //IndexParticipantes();
            
            //AddParticipante();
            //AddJugador();
            //AddEquipo();
            //AddDirectorTecnico();
            //AddArbitro();
            AddColegio();
            
            //DeleteParticipante();
            //DeleteJugador();
            //DeleteDirectorTecnico();

            //AsignarJugador();
            //AsignarColegioArbitro();
            //mostrarGenero();
            }

            //Método para AÑADIR PARTICIPANTE********************************************
            private static void AddParticipante()
            {
            var Participante = new Participante
            {
                numeroDocumento="10303675272",
                nombre = "MontGomery",
                apellido = "Burns",
                direccion = "Avenida Siempre Viva",
                numeroTelefono = "01800-98765",
                ciudad = "Springfield",
                genero = Genero.BiGenero
                
            };
             _repoParticipante.AddParticipante(Participante);
            }

            //Metodo para AÑADIR JUGADOR**********************************************************
            private static void AddJugador()
            {
                var Jugador = new Jugador
                {
                    
                    numeroDocumento="1061717456",
                    nombre = "James",
                    apellido = "Garcia",
                    direccion = "Envigado",
                    numeroTelefono = "+57 455688797",
                    ciudad = "La Guajira",
                    genero = (Genero)Enum.Parse(typeof(Genero), "Intersexual"),
                    numCamiseta = 10,
                    fechaNacimiento = Convert.ToDateTime("07/04/1999"),
                    posicion = Posicion.MedioCentro
                };
                _repoJugador.AddJugador(Jugador);
            }

            //Método ELIMINAR Participante**********************************************************
            private static void DeleteParticipante()
            {
                _repoParticipante.DeleteParticipante(8);
            }

            //Método ELIMINAR Jugador***************************************************************
            private static void DeleteJugador()
            {
                _repoJugador.DeleteJugador(7);
            }



            private static void BuscarParticipante()
            {
                int idParticipante = 6;
                var participante =_repoParticipante.GetParticipante(idParticipante);
                Console.WriteLine(participante.nombre + " "+ participante.apellido); 
            }
            
            private static void IndexParticipantes()
            {
                foreach (var participante in _repoParticipante.GetAllParticipantes())
                {
                   Console.WriteLine(participante.nombre + " "+ participante.apellido); 
                }
            }
            

            private static void AddEquipo()
            {
                var Equipo = new Equipo
                    {
                     nombre = "Millonarios",
                     local = true,
                     visitante = false
                    };
                _repoEquipo.AddEquipo(Equipo);

            }

            private static void DeleteEquipo()
            {
                _repoEquipo.DeleteEquipo(5);
            }

            
            private static void AsignarJugador()
            {
                var jugador = _repoEquipo.AsignarJugador(4,1);
                Console.WriteLine(jugador.nombre + " "+ jugador.apellido);
            }

            private static void mostrarGenero()
            {
                //int idParticipante = 1018;
                int numeroCamiseta = 10;
                //var participante =_repoParticipante.GetParticipante(idParticipante);
                var participante =_repoJugador.GetJugador(numeroCamiseta);
                Console.WriteLine("Para "+participante.nombre + " "+ participante.apellido+" Su genero es "+participante.genero);                
            }

            private static void AddDirectorTecnico()
            {

            var director = new Director_Tecnico
            {
                /*numeroDocumento="500400300-2",
                nombre = "Louis",
                apellido = "Van Gaal",
                direccion = "Amsterdam",
                numeroTelefono = "009-0180050400",
                ciudad = "Holanda",
                aniosExperiencia = "Bastantes",
                genero = Genero.Transexual,
                fechaNacimiento = Convert.ToDateTime("09/08/1951"),
                equiposDirigidos = eqDirigidos*/

                numeroDocumento="10403020",
                nombre = "Marcelo",
                apellido = "Gallardo",
                direccion = "Buenos Aires",
                numeroTelefono = "009-0180050400",
                ciudad = "Argentina",
                aniosExperiencia = "Pocos",
                genero = Genero.Transexual,
                fechaNacimiento = Convert.ToDateTime("18/01/1976")
                
            };
             _repoDirector.AddDirectorTecnico(director);
            }

            private static void DeleteDirectorTecnico()
            {
                _repoDirector.DeleteDirectorTecnico(5);
            }

            //Añadir COLEGIO
            private static void AddColegio()
            {
                var colegio = new Colegio
                    {
                     nombre = "ArbiAntioquia"
                    };
                _repoColegio.AddColegio(colegio);

            }

            //Añadir ARBITRO
            private static void AddArbitro()
            {
            var Arbitro = new Arbitro
            {
                numeroDocumento="10303675272",
                nombre = "",
                apellido = "Burns",
                direccion = "Avenida Siempre Viva",
                numeroTelefono = "01800-98765",
                ciudad = "Springfield",
                genero = Genero.BiGenero
                
            };
             _repoParticipante.AddArbitro(Participante);
            }


    }
}
