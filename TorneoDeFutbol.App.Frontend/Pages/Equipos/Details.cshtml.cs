using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.pages.Equipos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;

        public Equipo equipo { get;set; }

        public DetailsModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }

        public IActionResult OnGet(int idEquipo)
        {
            equipo = _repoEquipo.GetEquipo(idEquipo);
            if(equipo == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
