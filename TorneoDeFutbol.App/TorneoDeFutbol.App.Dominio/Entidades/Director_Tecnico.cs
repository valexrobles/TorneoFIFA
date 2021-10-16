using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Director_Tecnico: Participante
    {
        [Display(Name = "Años de Experiencia")]
        public int aniosExperiencia { get;set;}
    }
}