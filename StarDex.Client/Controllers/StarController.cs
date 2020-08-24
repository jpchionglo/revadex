using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StarDex.Client.Models;

namespace StarDex.Client.Controllers {
    public class StarController : Controller {
      [HttpGet]
      public IActionResult Get(string name) {
        string jsonString = null;
        HttpWebRequest request = (HttpWebRequest) WebRequest.Create($"https://domainserviceapi.azurewebsites.net/api/Star/{name}");
        HttpWebResponse response;
        try {
          response = (HttpWebResponse) request.GetResponse();
        } catch (WebException e) {
          StarViewModel model = new StarViewModel{Name = name};
          response = (HttpWebResponse) e.Response;
          if (response != null) {
            if ((int) response.StatusCode == 404) {
              model.reasonForError = "Either the API is not running, or a star with this name is not in the database. Please try again later.";
            } else {
              model.reasonForError = $"A {(int) response.StatusCode} error has occured processing your request";
            }
          } else {
            model.reasonForError = "There was a problem processing your request. Please try again later.";
          }
          return View("Error", model);
        }
        using (Stream stream = response.GetResponseStream()) {
          using (StreamReader reader = new StreamReader(stream)) {
            jsonString = reader.ReadToEnd();
          }
        }
        StarViewModel model2 = JsonConvert.DeserializeObject<StarViewModel>(jsonString);
        request = (HttpWebRequest) WebRequest.Create($"https://imageservicerevadex.azurewebsites.net/api/Image/{name}");
        try {
          response = (HttpWebResponse) request.GetResponse();
        } catch (WebException) {
          StarViewModel model = new StarViewModel{Name = name};
          model.reasonForError = "No star image";
          return View("Error", model);
        }
        using (Stream stream = response.GetResponseStream()) {
          using (StreamReader reader = new StreamReader(stream)) {
            model2.imageURL = reader.ReadToEnd();
          }
        }

        response.Dispose();
        return View("Star", model2);
      }
    }
}