using System.Collections.Generic;
using DomainService.Domain;
using DomainService.Domain.Models;
using DomainService.Storing.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DomainService.ClientMVC.Controllers
{

  [Route("api/[controller]")]
  [ApiController]

  public class StarController : ControllerBase
  {

    DomainServiceRepository repo = new DomainServiceRepository();
    JSONConvert jconv = new JSONConvert();

    [HttpGet("{name}")]
    public IActionResult Get(string name){

      StarModel star =  repo.GetStarByName(name);

      if (star == null){

        return NotFound();

      }

      return Ok(jconv.Convert(star));

    }

    [HttpGet]
    public IActionResult Get(){

      List<StarModel> stars = repo.GetAllStars();

      if (stars == null){

        return NotFound();

      }

      return Ok(jconv.Convert(stars));

    }

  }

}