using Nancy;
using PlacesBeen;
using System.Collections.Generic;

namespace PlacesBeenFunction
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/new"] = _ => {
        return View["places_form.cshtml"];
      };
      Post["/places"] = _ => {
        Place newPlace = new Place(Request.Form["city"], Request.Form["state"]);
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/{id}"] = parameters => {
        Place specificPlace = Place.Find(parameters.id);
        return View["places.cshtml", specificPlace];
      };
    }
  }
}
