using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.pages.Colegios
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioColegio _repoColegio;

        public Colegio colegio{ get;set; }

        public DetailsModel(IRepositorioColegio repoColegio)
        {
            _repoColegio = repoColegio;
        }

        public IActionResult OnGet(int idColegio)
        {
            colegio = _repoColegio.GetColegio(idColegio);
            if(colegio == null)
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
