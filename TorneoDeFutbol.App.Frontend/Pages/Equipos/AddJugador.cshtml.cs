using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Fontend.Pages.Equipos
{
    public class AddJugadorModel : PageModel
    {

        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioJugador _repoJugador;
        public Equipo equipo {get; set;}
        public IEnumerable<Jugador> jugadores {get; set;}
        public AddJugadorModel(IRepositorioEquipo repoEquipo, IRepositorioJugador repoJugador)
        {
            _repoEquipo = repoEquipo;
            _repoJugador = repoJugador;
        }

        public void OnGet(int idEquipo)
        {
            equipo = _repoEquipo.GetEquipo(idEquipo);
            jugadores = _repoJugador.GetAllJugadores();
        }

        public IActionResult OnPost(int idEquipo, int idParticipante)
        {
            _repoEquipo.AsignarJugador(idEquipo, idParticipante);
            return RedirectToPage("Details", new{idEquipo = idEquipo});
        }
    }
}