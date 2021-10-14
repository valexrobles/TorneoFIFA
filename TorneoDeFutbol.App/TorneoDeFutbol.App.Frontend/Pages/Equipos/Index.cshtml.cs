using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Equipos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public IEnumerable<Equipo> equipos {get; set;}
        

        
        public IndexModel(IRepositorioEquipo repoEquipo)
        {
            _repoEquipo = repoEquipo;
        }

       

        public void OnGet()
        {
            equipos = _repoEquipo.GetAllEquipos();
        }
    }
}
