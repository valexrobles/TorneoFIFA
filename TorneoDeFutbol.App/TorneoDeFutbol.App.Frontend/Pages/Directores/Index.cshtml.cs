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
        public int pActual  {get; set;}
        public string bActual  {get; set;}
        
        public IndexModel(IRepositorioDirector repoDirector)
        {
            _repoDirector = repoDirector;
        }

        /*public void OnGet()
        {
            directores = _repoDirector.GetAllDirectoresTecnicos();
        }*/
        public void OnGet(int? p, string b)
        {
            if (p.HasValue && p.Value != -1)
            {
                pActual = p.Value;
                directores = _repoDirector.GetDTPorGenero(p.Value);

            }
            else{
                pActual = -1;
                if (String.IsNullOrEmpty(b))
                {
                    bActual = "";
                    directores = _repoDirector.GetAllDirectoresTecnicos();
                }
                else
                {
                    bActual = b;
                    directores = _repoDirector.SearchDT(b);
                }
            }        
        }
    }
}
