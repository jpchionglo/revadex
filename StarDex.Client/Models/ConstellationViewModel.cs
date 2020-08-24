using System.Collections.Generic;

namespace StarDex.Client.Models {
  public class ConstellationViewModel {
    public string name { get; set; }
    public string imageURL { get; set; }
    public string description { get; set; }
    public List<StarViewModel> stars { get; set; }
  }
}