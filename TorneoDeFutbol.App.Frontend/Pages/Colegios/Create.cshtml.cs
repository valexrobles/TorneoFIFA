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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioColegio _repoColegio;

        public Colegio colegio { get;set; }

        public CreateModel(IRepositorioColegio repoColegio)
        {
            _repoColegio = repoColegio;
        }
        public void OnGet()
        {
            colegio = new Colegio();
        }

         public IActionResult OnPost(Colegio colegio)
        {
            if (ModelState.IsValid)
            {
                _repoColegio.AddColegio(colegio);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
