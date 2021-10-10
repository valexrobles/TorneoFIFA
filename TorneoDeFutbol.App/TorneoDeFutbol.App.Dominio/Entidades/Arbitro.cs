using System;
using System.ComponentModel.DataAnnotations;


namespace TorneoDeFutbol.App.Dominio


{
    public class Arbitro: Participante
    {
       
        
        public bool arbitroFIFA { get;set;}
        public DateTime fechaAfiliacionFIFA { get;set;}
        public Colegio colegio { get;set;}
    }
}