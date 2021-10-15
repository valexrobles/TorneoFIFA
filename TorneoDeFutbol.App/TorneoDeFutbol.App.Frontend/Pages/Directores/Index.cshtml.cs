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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirector _repoDirector;

        public IEnumerable<Director_Tecnico> directores {get; set;}
        
        public IndexModel(IRepositorioDirector repoDirector)
        {
            _repoDirector = repoDirector;
        }

        public void OnGet()
        {
            directores = _repoDirector.GetAllDirectoresTecnicos();
        }
    }
}
