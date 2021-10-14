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
        private readonly IRepositorioDirector _repoDirector_tecnico;
        public IEnumerable<Director_Tecnico> directores_tecnicos { get; set; }
        public IndexModel(IRepositorioDirector repoDirector_tecnico)
        {
            _repoDirector_tecnico = repoDirector_tecnico;
        }
        public void OnGet()
        {
            directores_tecnicos = _repoDirector_tecnico.GetAllDirectoresTecnicos();
        }
    }
}
