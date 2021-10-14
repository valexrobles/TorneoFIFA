using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;


namespace TorneoDeFutbol.App.Frontend.pages.Directores
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDirector _repoDirector_tecnico;
        public Director_Tecnico director_tecnico { get; set; }
        public DetailsModel(IRepositorioDirector repoDirector_tecnico)
        {
            _repoDirector_tecnico = repoDirector_tecnico;
        }
        public IActionResult OnGet(int id)
        {
            director_tecnico = _repoDirector_tecnico.GetDirectorTecnico(id);
            if(director_tecnico == null)
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
