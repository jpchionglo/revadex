using System;

namespace DomainService.Domain.Models
{

    public class PlanetSolarSystJunction
    {

      public int Id {get;set;}

      public PlanetModel Planet {get;set;}

      public SolarSystemModel SolarSystem {get;set;}

    }

}
