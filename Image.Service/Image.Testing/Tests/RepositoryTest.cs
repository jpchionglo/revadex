using Image.Domain.Models;
using Image.Storing.Repository;
using Xunit;

namespace Image.Testing.Tests
{
  public class RepositoryTest
  {
    [Theory]
    [InlineData("Earth")]
    [InlineData("Mercury")]
    public void GetImage_Test(string n)
    {

      ImageServiceRepository _repo = new ImageServiceRepository();
      string name = n;
      ImageModel img = new ImageModel();

      img = _repo.GetImage(name);

      Assert.True(img.Id != null);

    }


  }
}