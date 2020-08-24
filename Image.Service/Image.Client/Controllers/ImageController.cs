using System;
using Image.Domain.Models;
using Image.Storing.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Image.Client.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ImageController : ControllerBase
  {

    ImageServiceRepository _repo = new ImageServiceRepository();

    /* [HttpGet]
    public IActionResult Get()
    {
      //return all images
      return Ok();
    } */

    //httpget request for image by name
    [HttpGet("{name}")]
    public IActionResult Get( string name )
    {
      ImageModel img = _repo.GetImage(name);

      return Ok(img.Url);
    }
    
  }
}