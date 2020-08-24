using System.Collections.Generic;
using System.Linq;
using DomainService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DomainService.Storing.Repositories
{

  public class DomainServiceRepository
  {

    private DomainServiceDBContext db = new DomainServiceDBContext();

    public StarModel GetStarByName(string name){

      return db.Star.FirstOrDefault(s => s.Name.ToUpper().Equals(name.ToUpper()));

    }

    public PlanetModel GetPlanetByName(string name){

      return db.Planet.FirstOrDefault(p => p.Name.ToUpper().Equals(name.ToUpper()));

    }

    public SolarSystemModel GetSolarSystemByName(string name){

      SolarSystemModel solarSystem = db.SolarSystem.FirstOrDefault(s => s.Name.ToUpper().Equals(name.ToUpper()));

      List<PlanetSolarSystJunction> junctions = db.PlanetSolarSystJunction.Where(ps => ps.SolarSystem.Id == solarSystem.Id).Include("Planet").Include("SolarSystem").ToList();

      foreach (PlanetSolarSystJunction ps in junctions){

        solarSystem.Planets.Add(ps.Planet);

      }

      return solarSystem;

    }

    public ConstellationModel GetConstellationByName(string name){

      ConstellationModel constellation = db.Constellation.FirstOrDefault(s => s.Name.ToUpper().Equals(name.ToUpper()));

      List<StarConstJunction> junctions = db.StarConstJunction.Where(ps => ps.Constellation.Id == constellation.Id).Include("Star").Include("Constellation").ToList();

      foreach (StarConstJunction sc in junctions){

        constellation.Stars.Add(sc.Star);

      }

      return constellation;

    }

    public List<StarModel> GetAllStars(){

      return db.Star.ToList();

    }

    public List<PlanetModel> GetAllPlanets(){

      return db.Planet.ToList();

    }

    public List<SolarSystemModel> GetAllSolarSystems(){

      List<SolarSystemModel> SolarSystems = new List<SolarSystemModel>();
      
      foreach (SolarSystemModel solarSystem in db.SolarSystem.ToList()){

        SolarSystems.Add(GetSolarSystemByName(solarSystem.Name));

      }

      return SolarSystems;

    }

    public List<ConstellationModel> GetAllConstellations(){

      List<ConstellationModel> Constellations = new List<ConstellationModel>();
      
      foreach (ConstellationModel constellation in db.Constellation.ToList()){

        Constellations.Add(GetConstellationByName(constellation.Name));

      }

      return Constellations;

    }

  }

}