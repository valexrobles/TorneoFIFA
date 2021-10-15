using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Directores
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirector _repoDirector;

        public Director_Tecnico director { get;set; }

        public DetailsModel(IRepositorioDirector repoDirector)
        {
            _repoDirector = repoDirector;
        }

        public IActionResult OnGet(int id)
        {
            director = _repoDirector.GetDirectorTecnico(id);
            if(director == null)
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
