using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    public class Datos_Partido
    {
        [Key]
     public  int idDatosPartido { get;set; }
     [Display(Name = "Marcador")]
     public  string marcador { get;set; }
     [Display(Name = "Tarjetas Amarillas Local")]
     public  int amarillasLocal{ get;set; }
     [Display(Name = "Tarjetas Rojas Local")]
     public  int rojasLocal { get;set; }
     
     [Display(Name = "Tarjetas Amarillas Visitante")]
     public  int amarillasVisitante { get;set; }
     [Display(Name = "Tarjetas Rojas Visitante")]
     public  int rojasVisitante { get;set; }
     [Display(Name = "Goles Visitante")]
     public  int golesV { get;set; }
     [Display(Name = "Goles Local")]
     public  int golesL { get;set; }
     [Display(Name = "Duración del Encuentro Deportivo")]
     public  int minutosJugados { get;set; }
     
     [Display(Name = "Fecha de Realización")]
     public DateTime fecha { get;set;}
     public  Equipo objEquipo { get;set; }
     public Estadio objEstadio { get;set; }
     public Arbitro objArbitro { get;set; }
     public  List<Estadio> listaEstadios { get;set;}
     public  List<Equipo> listaEquiposV { get;set; }
     public List<Equipo> listaEquiposL {get; set;}
      
      [Display(Name = "Equipo Local")]
     public enumListaEquiposL itemEquipoL { get;set; }
      [Display(Name = "Equipo Visitante")]
     public enumListaEquiposV itemEquipoV { get;set; }
      [Display(Name = "Estadio")]
     public enumListaEstadios itemEstadio { get;set; }
      [Display(Name = "Lugar del Encuentro")]
     public enumListaMunicipios itemMunicipio { get;set; }
     
    }
}