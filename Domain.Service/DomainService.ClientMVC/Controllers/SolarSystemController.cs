using System.Collections.Generic;
using DomainService.Domain;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DomainService.ClientMVC.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class SolarSystemController : ControllerBase
  {

    DomainServiceRepository repo = new DomainServiceRepository();
    JSONConvert jconv = new JSONConvert();

    [HttpGet("{name}")]
    public IActionResult Get(string name){

      SolarSystemModel solarSystem =  repo.GetSolarSystemByName(name);

      if (solarSystem == null){

        return NotFound();

      }

      return Ok(jconv.Convert(solarSystem));

    }

    [HttpGet]
    public IActionResult Get(){

      List<SolarSystemModel> solarSystems = repo.GetAllSolarSystems();

      if (solarSystems == null){

        return NotFound();

      }

      return Ok(jconv.Convert(solarSystems));

    }

  }

}