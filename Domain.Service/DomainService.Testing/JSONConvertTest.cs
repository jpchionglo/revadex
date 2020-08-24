using System;
using System.Collections.Generic;
using DomainService.Domain;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Xunit;

namespace DomainService.Testing
{
    public class JSONConvertTest
    {

        DomainServiceRepository repo = new DomainServiceRepository();

        [Fact]
        public void StarConvert()
        {

          Console.WriteLine("JSON Star Convert Test");

          JSONConvert jconv = new JSONConvert();

          StarModel star = repo.GetStarByName("Dubhe");

          List<StarModel> stars = repo.GetAllStars();

          Console.WriteLine(jconv.Convert(star));

          Console.WriteLine(jconv.Convert(stars));

        }

        [Fact]
        public void ConstellationConvert(){

          Console.WriteLine("Constellation Convert Test:");

          ConstellationModel bigDipper = repo.GetConstellationByName("Ursa Major");

          List<ConstellationModel> constellations = repo.GetAllConstellations();

          JSONConvert jconv = new JSONConvert();

          Console.WriteLine(jconv.Convert(bigDipper));

          Console.WriteLine(jconv.Convert(constellations));

        }

        [Fact]
        public void PlanetConvert(){

          Console.WriteLine("Planet Convert Test:");

          PlanetModel bigDipper = repo.GetPlanetByName("Neptune");

          List<ConstellationModel> constellations = repo.GetAllConstellations();

          JSONConvert jconv = new JSONConvert();

          Console.WriteLine(jconv.Convert(bigDipper));

          Console.WriteLine(jconv.Convert(constellations));

        }



    }
}
