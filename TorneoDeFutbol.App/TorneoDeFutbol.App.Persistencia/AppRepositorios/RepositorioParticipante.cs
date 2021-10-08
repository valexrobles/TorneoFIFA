using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq; 
using System;

namespace TorneoDeFutbol.App.Persistencia

{
    public class RepositorioParticipante : IRepositorioParticipante
    {
        private readonly AppContext _appContext  = new AppContext();
        
        Participante IRepositorioParticipante.AddParticipante(Participante participante) 
        {
            var participanteAdicionado = _appContext.Participantes.Add(participante);
            _appContext.SaveChanges();
            return participanteAdicionado.Entity;
        } 
         
        IEnumerable<Participante> IRepositorioParticipante.GetAllParticipantes()
         {
             return _appContext.Participantes;
         }
        
        
        public void DeleteParticipante(int idParticipante)
        {
            
            var participanteEncontrado = _appContext.Participantes.Find(idParticipante);
            
            if (participanteEncontrado == null)
                return;
            _appContext.Participantes.Remove(participanteEncontrado);
            _appContext.SaveChanges();

         }

        public Participante GetParticipante(int idParticipante)
        {
            return _appContext.Participantes.Where(x=>x.idParticipante==idParticipante).FirstOrDefault();
        }


        Participante IRepositorioParticipante.UpdateParticipante(Participante participante)
        {
            var participanteEncontrado = _appContext.Participantes.Find(participante.idParticipante);
            
            if (participanteEncontrado != null)
            {

                participanteEncontrado.nombre = participante.nombre;
                participanteEncontrado.apellido = participante.apellido;
                participanteEncontrado.numTelefono = participante.numTelefono;
                participanteEncontrado.direccion = participante.direccion;
                participanteEncontrado.ciudad = participante.ciudad;
                participanteEncontrado.fechaNacimiento = participante.fechaNacimiento;
                participanteEncontrado.genero = participante.genero;
                participanteEncontrado.idParticipante = participante.idParticipante;
                participanteEncontrado.numDocumento = participante.numDocumento;
                 _appContext.SaveChanges();
            }
            return participanteEncontrado;
        }

    }
}

