using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
    public class PlanetController : Controller {
      [HttpGet]
      public IActionResult Get(string name) {
        string jsonString = null;
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://domainserviceapi.azurewebsites.net/api/Planet/{name}");
        using (HttpWebResponse response = (HttpWebResponse) request.GetResponse()) {
          using (Stream stream = response.GetResponseStream()) {
            using (StreamReader reader = new StreamReader(stream)) {
              jsonString = reader.ReadToEnd();
            }
          }
        }
        PlanetViewModel model = JsonConvert.DeserializeObject<PlanetViewModel>(jsonString);
        request = (HttpWebRequest) WebRequest.Create($"https://imageservicerevadex.azurewebsites.net/api/Image/{name}");
        using (HttpWebResponse response = (HttpWebResponse) request.GetResponse()) {
          using (Stream stream = response.GetResponseStream()) {
            using (StreamReader reader = new StreamReader(stream)) {
              model.ImageURL = reader.ReadToEnd();
            }
          }
        }
        return View("Planet", model);
      }
    }
}