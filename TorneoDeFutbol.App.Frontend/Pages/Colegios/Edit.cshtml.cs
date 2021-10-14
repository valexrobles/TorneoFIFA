using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Colegios
{
    public class EditModel : PageModel
    {
      
        private readonly IRepositorioColegio _repoColegio;

        public Colegio colegio { get;set; }

        public EditModel(IRepositorioColegio repoColegio)
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

         public IActionResult OnPost(Colegio colegio)
        {
            _repoColegio.UpdateColegio(colegio);
            return RedirectToPage("Index");
        }
    }
}
