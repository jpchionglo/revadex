using System.Collections.Generic;

namespace StarDex.Client.Models {
  public class HomeViewModel {
    public List<ConstellationButtonModel> stars;
    public List<PlanetViewModel> planets;
    public string name { get; set; }
  }
}