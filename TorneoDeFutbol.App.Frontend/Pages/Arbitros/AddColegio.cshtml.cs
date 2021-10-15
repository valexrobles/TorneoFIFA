using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Fontend.Pages.Arbitros
{
    public class AddColegioModel : PageModel
    {

        private readonly IRepositorioArbitro _repoArbitro;
        private readonly IRepositorioColegio _repoColegio;
        public Arbitro arbitro {get; set;}
        public IEnumerable<Colegio> colegios {get; set;}
        public AddColegioModel(IRepositorioArbitro repoArbitro, IRepositorioColegio repoColegio)
        {
            _repoArbitro = repoArbitro;
            _repoColegio = repoColegio;
        }

        public void OnGet(int idParticipante)
        {
            arbitro = _repoArbitro.GetArbitro(idParticipante);
            colegios = _repoColegio.GetAllColegios();
        }

        public IActionResult OnPost(int idParticipante, int idColegio)
        {
            _repoArbitro.AsignarColegio(idParticipante, idColegio);
            return RedirectToPage("Details", new{idParticipante = idParticipante});
        }
    }
}