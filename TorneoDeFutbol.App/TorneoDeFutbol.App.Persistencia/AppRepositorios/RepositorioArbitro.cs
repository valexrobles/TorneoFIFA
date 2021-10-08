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

        //Método Actualizar arbitro
        Arbitro IRepositorioArbitro.UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitros.Find(arbitro.idParticipante);
            
            if (arbitroEncontrado != null)
            {

                arbitroEncontrado.nombre = arbitro.nombre;
                arbitroEncontrado.apellido = arbitro.apellido;
                arbitroEncontrado.numTelefono = arbitro.numTelefono;
                arbitroEncontrado.direccion = arbitro.direccion;
                arbitroEncontrado.ciudad = arbitro.ciudad;
                arbitroEncontrado.fechaNacimiento = arbitro.fechaNacimiento;
                arbitroEncontrado.genero = arbitro.genero;
                arbitroEncontrado.idParticipante = arbitro.idParticipante;
                arbitroEncontrado.numDocumento = arbitro.numDocumento;
                arbitroEncontrado.arbitroFIFA = arbitro.arbitroFIFA;
                arbitroEncontrado.fechaAfiliacionFIFA = arbitro.fechaAfiliacionFIFA;
                arbitroEncontrado.colegio = arbitro.colegio;

                 _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }
        

    }
}
