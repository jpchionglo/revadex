using System.Collections.Generic;
using DomainService.Domain.Models;
using Newtonsoft.Json;

namespace DomainService.Domain
{

  public class JSONConvert
  {

    public string Convert(StarModel star){

      return JsonConvert.SerializeObject(star);

    }

    public string Convert(ConstellationModel constellation){

      return JsonConvert.SerializeObject(constellation);

    }

    public string Convert(PlanetModel planet){

      return JsonConvert.SerializeObject(planet);

    }

    public string Convert(SolarSystemModel solarSystem){

      return JsonConvert.SerializeObject(solarSystem);

    }

    public string Convert(List<StarModel> stars){

      return JsonConvert.SerializeObject(stars);

    }

    public string Convert(List<ConstellationModel> constellations){

      return JsonConvert.SerializeObject(constellations);

    }

    public string Convert(List<PlanetModel> planets){

      return JsonConvert.SerializeObject(planets);

    }

    public string Convert(List<SolarSystemModel> solarSystems){

      return JsonConvert.SerializeObject(solarSystems);

    }

  }

}