using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        Municipio IRepositorioMunicipio.AddMunicipio (Municipio municipio) 

        {
            var municipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        } 


         IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios()
         {
             return _appContext.Municipios;
         }



        void IRepositorioMunicipio.DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (municipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(municipioEncontrado);
            _appContext.SaveChanges();
         }


        Municipio IRepositorioMunicipio.GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipios.Find(idMunicipio);
        }

    }
}
