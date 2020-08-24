using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
  public class ConstellationController : Controller {
    // the expectation is that only major stars in the constellations will be returned
    [HttpGet]
    public IActionResult Get(string name) {
      string jsonString = "";
      HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://domainserviceapi.azurewebsites.net/api/Constellation/{name}");
      HttpWebResponse response;
      try {
        response = (HttpWebResponse) request.GetResponse();
      } catch (WebException e) {
        response = (HttpWebResponse) e.Response;
        if (response != null) {
          return Redirect("/");
        } else {
          return Redirect("/");
        }
      }
      using (response) {
        using (Stream stream = response.GetResponseStream()) {
          using (StreamReader reader = new StreamReader(stream)) {
            jsonString = reader.ReadToEnd();
          }
        }
      }
      JObject json = JObject.Parse(jsonString);

      ConstellationViewModel model = new ConstellationViewModel{
        name = name,
        description = (string) json["Description"],
        stars = new List<StarViewModel>()
      };
      foreach (JToken star in json["Stars"]) {
        model.stars.Add(new StarViewModel{Name = (string) star["Name"]});
      }

      request = (HttpWebRequest) WebRequest.Create($"https://imageservicerevadex.azurewebsites.net/api/Image/{name}");
      try {
        response = (HttpWebResponse) request.GetResponse();
        using (response) {
        using (Stream stream = response.GetResponseStream()) {
          using (StreamReader reader = new StreamReader(stream)) {
            model.imageURL = reader.ReadToEnd();
          }
        }
      }
      } catch (WebException e) {
        response = (HttpWebResponse) e.Response;
      }

      return View("Constellation", model);
    }
  }
}