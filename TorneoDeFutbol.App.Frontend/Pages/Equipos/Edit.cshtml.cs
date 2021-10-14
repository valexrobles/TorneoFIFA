using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Equipos
{
    public class EditModel : PageModel
    {
      
        private readonly IRepositorioEquipo _repoEquipo;

        public Equipo equipo { get;set; }

        public EditModel(IRepositorioEquipo repoEquipo)
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

         public IActionResult OnPost(Equipo equipo)
        {
            _repoEquipo.UpdateEquipo(equipo);
            return RedirectToPage("Index");
        }
    }
}
