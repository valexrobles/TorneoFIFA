using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext(); 
        
        Arbitro IRepositorioArbitro.AddArbitro (Arbitro arbitro) 
        {
            var arbitroAdicionado = _appContext.Arbitros.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        } 


         IEnumerable<Arbitro> IRepositorioArbitro.GetAllArbitros()
         {
             return _appContext.Arbitros;
         }


         public void DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitros.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
         }


         public Arbitro GetArbitro(int idArbitro)
        {
            return _appContext.Arbitros.Find(idArbitro);
        }
       
        Colegio IRepositorioArbitro.AsignarColegio(int idArbitro, int idColegio)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(idArbitro);
            if (arbitroEncontrado != null)
            {
                var colegioEncontrado = _appContext.Colegios.Find(idColegio);
                if (colegioEncontrado != null)
                {
                    arbitroEncontrado.colegio = colegioEncontrado;
                    _appContext.SaveChanges();
                }
                return colegioEncontrado;
            }
            return null;
        }
        

    }
}
