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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDatosPartido _repoDatosPartido;

        public Datos_Partido datosPartido { get;set; }

        public CreateModel(IRepositorioDatosPartido repoDatosPartido)
        {
            _repoDatosPartido = repoDatosPartido;
        }
        public void OnGet()
        {
            datosPartido = new Datos_Partido();
        }

        public IActionResult OnPost(Datos_Partido datosPartido)
        {
            _repoDatosPartido.AddDatosPartido(datosPartido);
            return RedirectToPage("Index");
        }
    }
}
