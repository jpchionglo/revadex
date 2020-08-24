using System.Collections.Generic;
using DomainService.Domain;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DomainService.ClientMVC.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class ConstellationController : ControllerBase
  {

    DomainServiceRepository repo = new DomainServiceRepository();
    JSONConvert jconv = new JSONConvert();

    [HttpGet("{name}")]
    public IActionResult Get(string name){

      ConstellationModel constellation =  repo.GetConstellationByName(name);

      if (constellation == null){

        return NotFound();

      }

      return Ok(jconv.Convert(constellation));

    }


    [HttpGet]
    public IActionResult Get(){

      List<ConstellationModel> constellations = repo.GetAllConstellations();

      if (constellations == null){

        return NotFound();

      }

      return Ok(jconv.Convert(constellations));

    }

  }

}