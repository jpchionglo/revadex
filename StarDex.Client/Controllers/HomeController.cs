using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
  public class HomeController : Controller {
    private readonly ILogger<HomeController> _logger;
    private List<ConstellationButtonModel> starButtons;
    private List<PlanetViewModel> planetButtons;

    public HomeController(ILogger<HomeController> logger) {
      _logger = logger;
    }

    public IActionResult Index() {
      starButtons = StarButtons();
      planetButtons = PlanetButtons();
      HomeViewModel model = new HomeViewModel();
      model.stars = starButtons;
      model.planets = planetButtons;
      return View(model);
    }

    List<ConstellationButtonModel> StarButtons() {
      string jsonString = null;
      HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://domainserviceapi.azurewebsites.net/api/Constellation/");
      using (HttpWebResponse response = (HttpWebResponse) request.GetResponse()) {
        using (Stream stream = response.GetResponseStream()) {
          using (StreamReader reader = new StreamReader(stream)) {
            jsonString = reader.ReadToEnd();
          }
        }
      }
      List<ConstellationButtonModel> constellations = new List<ConstellationButtonModel>();
      JArray array = JArray.Parse(jsonString);
      foreach (JToken token in array) {
        constellations.Add(new ConstellationButtonModel{name = (string) token["Name"], top = (double) token["Top"], left = (double) token["Left"]});
      }
      return constellations;
    }

    List<PlanetViewModel> PlanetButtons() {
      string jsonString = null;
      HttpWebRequest request = (HttpWebRequest) WebRequest.Create("https://domainserviceapi.azurewebsites.net/api/Planet/");
      using (HttpWebResponse response = (HttpWebResponse) request.GetResponse()) {
        using (Stream stream = response.GetResponseStream()) {
          using (StreamReader reader = new StreamReader(stream)) {
            jsonString = reader.ReadToEnd();
          }
        }
      }
      List<PlanetViewModel> planets = new List<PlanetViewModel>();
      JArray array = JArray.Parse(jsonString);
      foreach (JToken token in array) {
        planets.Add(new PlanetViewModel{Name = (string) token["Name"], Top = (double) token["Top"], Left = (double) token["Left"]});
      }
      return planets;
    }

    public IActionResult Privacy() {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
