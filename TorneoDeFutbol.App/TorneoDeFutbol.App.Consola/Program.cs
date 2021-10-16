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
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework");
            //BuscarParticipante();
            //IndexParticipantes();
            
            //AddParticipante();
            //AddJugador();
            //AddEquipo();
            AddDirectorTecnico();
            //AddArbitro();
            //AddColegio();
            
            //DeleteParticipante();
            //DeleteJugador();
            //DeleteDirectorTecnico();

            //AsignarJugador();
            //AsignarColegio();
            //mostrarGenero();
            }

            //Método para AÑADIR PARTICIPANTE********************************************
            private static void AddParticipante()
            {
            var Participante = new Participante
            {
                numDocumento="3435646748",
                nombre = "MontGomery",
                apellido = "Burns",
                direccion = "Avenida Siempre Viva",
                numTelefono = "01800-98765",
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
                    
                    numDocumento="1061717456",
                    nombre = "Diego",
                    apellido = "Maradona",
                    direccion = "La plata 123",
                    numTelefono = "54263637",
                    ciudad = "Avellaneda",
                    genero = (Genero)Enum.Parse(typeof(Genero), "PanSexual"),
                    numCamiseta = 1010,
                    fechaNacimiento = Convert.ToDateTime("11/04/1940"),
                    posicion = Posicion.DelanteroExtremo
                };
                _repoJugador.AddJugador(Jugador);
            }

            //Método ELIMINAR Participante**********************************************************
            private static void DeleteParticipante()
            {
                _repoParticipante.DeleteParticipante(10);
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
                numDocumento="500400300-2",
                nombre = "Pecoso",
                apellido = "Castro",
                direccion = "Wall Street",
                numTelefono = "01800-3536",
                ciudad = "Mánchester",
                aniosExperiencia = 9,
                genero = Genero.Transexual,
                fechaNacimiento = Convert.ToDateTime("27/12/1978")

                /*numDocumento="10403020",
                nombre = "Marcelo",
                apellido = "Gallardo",
                direccion = "Buenos Aires",
                numTelefono = "009-0180050400",
                ciudad = "Argentina",
                aniosExperiencia = "Pocos",
                genero = Genero.Transexual,
                fechaNacimiento = Convert.ToDateTime("18/01/1976")*/
                
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
            var arbitro = new Arbitro
            {
                numDocumento="34567892",
                nombre = "Wilmar",
                apellido = "Roldan",
                direccion = "Avenida Circunvalar 102",
                numTelefono = "300660700",
                ciudad = "Ibague",
                genero = Genero.NoBinario,
                arbitroFIFA = true,
                fechaNacimiento = Convert.ToDateTime("25/04/1976"),
                fechaAfiliacionFIFA = Convert.ToDateTime("31/08/2018")
                
            };
             _repoArbitro.AddArbitro(arbitro);
            }

            //Asignar COLEGIO
            public static void AsignarColegio()
            {
                _repoArbitro.AsignarColegio(2, 1);
            }


    }
}
