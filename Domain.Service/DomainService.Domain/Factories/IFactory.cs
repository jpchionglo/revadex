using DomainService.Domain.Models;

namespace DomainService.Domain.Factories
{

  public interface IFactory
  {

    AModel Create(string s);

  }

}