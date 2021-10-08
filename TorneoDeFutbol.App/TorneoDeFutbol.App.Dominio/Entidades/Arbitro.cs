using System;
namespace TorneoDeFutbol.App.Dominio

{
    public class Arbitro: Participante
    {
        public Colegio colegio { get;set; }
        public bool arbitroFIFA { get;set;}
        public DateTime fechaAfiliacionFIFA { get;set;}
    }
}