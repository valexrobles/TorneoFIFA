using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;
/*
namespace TorneoDeFutbol.App.Frontend.Pages.DatosPartidos
{
    public class EditModel : PageModel
    {
      
        private readonly IRepositorioDatosPartido _repoDatosPartido;

        public DatosPartidos datosPartidos{ get;set; }

        public EditModel(IRepositorioDatosPartido repoDatosPartido)
        {
            _repoDatosPartido = repoDatosPartido;
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
}*/
