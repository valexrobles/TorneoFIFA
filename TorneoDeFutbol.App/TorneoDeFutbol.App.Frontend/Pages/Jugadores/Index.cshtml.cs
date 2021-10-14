using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Jugadores
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public IEnumerable<Jugador> jugadores {get; set;}
        public int pActual  {get; set;}
        public string bActual  {get; set;}
        
        public IndexModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }

       

         public void OnGet(int? p, string b)
        {
            if (p.HasValue && p.Value != -1)
            {
                pActual = p.Value;
                jugadores = _repoJugador.GetJugadoresPosicion(p.Value);

            }
            else{
                pActual = -1;
                if (String.IsNullOrEmpty(b))
                {
                    bActual = "";
                    jugadores = _repoJugador.GetAllJugadores();
                }
                else
                {
                    bActual = b;
                    jugadores = _repoJugador.SearchJugadores(b);
                }
            }
            
        }
    }
}
