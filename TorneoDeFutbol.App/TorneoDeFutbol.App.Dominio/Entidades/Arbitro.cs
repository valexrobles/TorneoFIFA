using System;
using System.ComponentModel.DataAnnotations;


namespace TorneoDeFutbol.App.Dominio


{
    public class Arbitro: Participante
    {
        [Key]
        
        public bool arbitroFIFA { get;set;}
        public DateTime fechaAfiliacionFIFA { get;set;}
    }
}