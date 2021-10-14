using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Directores
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirector _repoDirector;

        public Director_Tecnico director { get;set; }

        public CreateModel(IRepositorioDirector repoDirector)
        {
            _repoDirector = repoDirector;
        }
        public void OnGet()
        {
            director = new Director_Tecnico();
        }

        public IActionResult OnPost(Director_Tecnico director)
        {
            _repoDirector.AddDirectorTecnico(director);
            return RedirectToPage("Index");
        }
    }
}
