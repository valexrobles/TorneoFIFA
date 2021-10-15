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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDatosPartido _repoDatosPartido;

        public Datos_Partido datosPartido { get;set; }

        public DetailsModel(IRepositorioDatosPartido repoDatosPartido)
        {
            _repoDatosPartido = repoDatosPartido;
        }

        public IActionResult OnGet(int id)
        {
            datosPartido = _repoDatosPartido.GetDatosPartido(id);
            if(datosPartido == null)
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
