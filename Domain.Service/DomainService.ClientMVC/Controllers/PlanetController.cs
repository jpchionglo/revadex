using System.Collections.Generic;
using DomainService.Domain;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DomainService.ClientMVC.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class PlanetController : ControllerBase
  {

    DomainServiceRepository repo = new DomainServiceRepository();
    JSONConvert jconv = new JSONConvert();

    [HttpGet("{name}")]
    public IActionResult Get(string name){

      PlanetModel planet =  repo.GetPlanetByName(name);

      if (planet == null){

        return NotFound();

      }

      return Ok(jconv.Convert(planet));

    }

    [HttpGet]
    public IActionResult Get(){

      List<PlanetModel> planets = repo.GetAllPlanets();

      if (planets == null){

        return NotFound();

      }

      return Ok(jconv.Convert(planets));

    }

  }

}