using DomainService.Domain.Models;

namespace DomainService.Domain.Factories
{

  public class SpaceFactory : IFactory
  {

    public AModel Create(string s)
    {

      if (s.ToUpper().Equals("PLANET")){

        return new PlanetModel();

      } else if (s.ToUpper().Equals("STAR")){

        return new StarModel();

      }

      return null;

    }

  }

}