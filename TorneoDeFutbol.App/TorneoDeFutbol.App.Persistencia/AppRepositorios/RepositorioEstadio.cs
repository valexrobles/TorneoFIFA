using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();
        

        Estadio IRepositorioEstadio.AddEstadio (Estadio estadio) 
        {
            var estadioAdicionado = _appContext.Estadios.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        } 


         IEnumerable<Estadio> IRepositorioEstadio.GetAllEstadios()
         {
             return _appContext.Estadios;
         }


        void IRepositorioEstadio.DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(idEstadio);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadios.Remove(estadioEncontrado);
            _appContext.SaveChanges();
         }


        Estadio IRepositorioEstadio.GetEstadio(int Id_Estadio)
        {
            var estadio = _appContext.Estadios
                .Where(e => e.idEstadio == Id_Estadio)
                .Include(e => e.municipio)
                .FirstOrDefault();
            return estadio;
        }

        Estadio IRepositorioEstadio.UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado=_appContext.Estadios.Find(estadio.idEstadio);
            if (estadioEncontrado!=null)
            {
                estadioEncontrado.nombre=estadio.nombre;
                estadioEncontrado.direccion=estadio.direccion;
                estadioEncontrado.capacidadEspectadores=estadio.capacidadEspectadores;

                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
        Municipio IRepositorioEstadio.AsignarMunicipio(int Id_Estadio, int Id_Municipio)
        {
            var estadioEncontrado = _appContext.Estadios.Find(Id_Estadio);
            if (estadioEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipios.Find(Id_Municipio);
                if (municipioEncontrado != null)
                {
                    estadioEncontrado.municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }
                return municipioEncontrado;
            }
            return null;
        }

    }
}
