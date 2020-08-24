using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainService.Domain.Models
{

    public class SolarSystemModel : AModel
    {

      [NotMapped]
      public List<PlanetModel> Planets {get;set;}

      public string Description {get;set;}

      public SolarSystemModel(){

        Planets = new List<PlanetModel>();

      }

    }

}
