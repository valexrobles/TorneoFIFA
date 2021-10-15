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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDatosPartido _repoDatosPartido;

        public IEnumerable<Datos_Partido> datosPartidos {get; set;}
        
        public IndexModel(IRepositorioDatosPartido repoDatosPartido)
        {
            _repoDatosPartido = repoDatosPartido;
        }

        public void OnGet()
        {
            datosPartidos = _repoDatosPartido.GetAllDatosPartidos();
        }
    }
}
