using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.DatosPartidos
{
    public class AddArbitroModel : PageModel
    {
        private readonly IRepositorioDatosPartido _repoDatospartido;
        private readonly IRepositorioArbitro _repoArbitro;
        public Datos_Partido datosPartido { get; set; }
        public IEnumerable<Arbitro> arbitros { get; set; }
        public AddArbitroModel(IRepositorioDatosPartido repoDatosPartido, IRepositorioArbitro repoArbitro)
        {
            _repoDatospartido = repoDatosPartido;
            _repoArbitro = repoArbitro;
        }
        public void OnGet(int idParticipante)
        {
            datosPartido = _repoDatospartido.GetDatosPartido(idParticipante);
            arbitros = _repoArbitro.GetAllArbitros();
        }
        public IActionResult OnPost(int idDatosPartido, int idParticipante)
        {
            _repoDatospartido.AsignarArbitro(idDatosPartido, idParticipante);
            return RedirectToPage("Details", new{id = idDatosPartido});
        }
    }
}
