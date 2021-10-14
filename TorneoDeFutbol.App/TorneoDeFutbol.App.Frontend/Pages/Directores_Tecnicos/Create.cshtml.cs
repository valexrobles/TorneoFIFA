using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Directores_Tecnicos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioDirector _repoDirector_tecnico;
        public Director_Tecnico director_tecnico { get; set; }
        public CreateModel(IRepositorioDirector repoDirector_tecnico)
        {
            _repoDirector_tecnico = repoDirector_tecnico;
        }
        public void OnGet()
        {
            director_tecnico = new Director_Tecnico();
        }
        public IActionResult OnPost(Director_Tecnico director_Tecnico)
        {
            if (ModelState.IsValid)
            {
                _repoDirector_tecnico.AddDirectorTecnico(director_Tecnico);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
