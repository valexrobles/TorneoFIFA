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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioColegio _repoColegio;
        public IEnumerable<Colegio> colegios {get; set;}
        
        public IndexModel(IRepositorioColegio repoColegio)
        {
            _repoColegio = repoColegio;
        }

       

        public void OnGet()
        {
            colegios = _repoColegio.GetAllColegios();
        }
    }
}
