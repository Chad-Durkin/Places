using System.Collections.Generic;

namespace PlacesBeen
{
  public class Place
  {
    private string _city;
    private string _state;
    private int _id;

    private static List<Place> _placesbeen = new List<Place> {};

    public Place(string city, string state)
    {
      _city = city;
      _state = state;
      _placesbeen.Add(this);
      _id = _placesbeen.Count;
    }

    public string GetCity()
    {
      return _city;
    }

    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public string GetState()
    {
      return _state;
    }

    public void SetState(string newState)
    {
      _state = newState;
    }

    public static List<Place> GetAll()
    {
      return _placesbeen;
    }

    public int GetId()
    {
      return _id;
    }
    
    public static Place Find(int searchId)
    {
      return _placesbeen[searchId-1];
    }

    public static void ClearAll()
    {
      _placesbeen.Clear();
    }
  }
}
