using System;
using System.Collections.Generic;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Xunit;

namespace DomainService.Testing
{
    public class PlanetRepoTest
    {
        [Fact]
        public void GetPlanet()
        {

          Console.WriteLine("Get Planet Test:");

          DomainServiceRepository repo = new DomainServiceRepository();

          Console.WriteLine(repo.GetPlanetByName("Earth").Name + "\n");

        }

        [Fact]
        public void GetSolarSystem()
        {

          Console.WriteLine("Get Solar System Test:");

          DomainServiceRepository repo = new DomainServiceRepository();
          SolarSystemModel solarSystem = repo.GetSolarSystemByName("The Solar System");
          
          Console.WriteLine("The Solar System Planets: ");

          foreach (PlanetModel planet in solarSystem.Planets){
            Console.WriteLine(planet.Name);
          }

          Console.WriteLine("");

        }

        [Fact]
        public void GetAllPlanets(){

          Console.WriteLine("Get All Planets Test: ");

          DomainServiceRepository repo = new DomainServiceRepository();

          List<PlanetModel> planets = repo.GetAllPlanets();

          foreach(PlanetModel planet in planets){

            Console.WriteLine(planet.Name);

          }

        }

        [Fact]
        public void GetAllSolarSystems(){

          Console.WriteLine("Get All Solar Systems Test: ");

          DomainServiceRepository repo = new DomainServiceRepository();

          List<SolarSystemModel> solarSystems = repo.GetAllSolarSystems();

          foreach(SolarSystemModel solarSystem in solarSystems){

            Console.WriteLine(solarSystem.Name);
            
            foreach(PlanetModel planet in solarSystem.Planets){

              Console.WriteLine(planet.Name);

            }

          }
          

        }
    }
}
