using System.Linq;
using Image.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Image.Storing.Repository
{
  public class ImageServiceRepository
  {
    private ImageServiceDBContext _db = new ImageServiceDBContext();

    //Get Image by name
    public ImageModel GetImage(string name)
    {
      System.Console.WriteLine(name);

      return _db.Images.FirstOrDefault(img => img.Name.ToUpper().Equals(name.ToUpper()));
    }


  }
}