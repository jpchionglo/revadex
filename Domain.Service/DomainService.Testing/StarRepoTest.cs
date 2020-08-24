using System;
using System.Collections.Generic;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Xunit;

namespace DomainService.Testing
{
    public class StarRepoTest
    {
        [Fact]
        public void GetStar()
        {

          Console.WriteLine("Get Star Test:");

          DomainServiceRepository repo = new DomainServiceRepository();

          Console.WriteLine(repo.GetStarByName("Dubhe").Name + "\n");

        }

        [Fact]
        public void GetConstellation()
        {

          Console.WriteLine("Get Constellation Test:");

          DomainServiceRepository repo = new DomainServiceRepository();
          ConstellationModel bigDipper = repo.GetConstellationByName("Ursa Major");
          
          Console.WriteLine("Big Dipper Stars: ");

          foreach (StarModel star in bigDipper.Stars){
            Console.WriteLine(star.Name);
          }

          Console.WriteLine("");

        }

        [Fact]
        public void GetAllStars(){

          Console.WriteLine("Get All Stars Test: ");

          DomainServiceRepository repo = new DomainServiceRepository();

          List<StarModel> stars = repo.GetAllStars();

          foreach(StarModel star in stars){

            Console.WriteLine(star.Name);

          }

        }

        [Fact]
        public void GetAllConstellations(){

          Console.WriteLine("Get All Constellations Test: ");

          DomainServiceRepository repo = new DomainServiceRepository();

          List<ConstellationModel> Constellations = repo.GetAllConstellations();

          foreach(ConstellationModel constellation in Constellations){

            Console.WriteLine(constellation.Name);
            
            foreach(StarModel star in constellation.Stars){

              Console.WriteLine(star.Name);

            }

          }
          

        }

    }
}
