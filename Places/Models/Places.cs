using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string CountryName { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };

    public Places(string cityName, string)
    {
      CityName = cityName;
      _instances.Add(this);
      Id + _instances.Count;
    }

//     public static List<Place> GetAll()
//     {
//       return _instances;
//     }
//  Countr
//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }

//      public static Place Find(int searchId)
//     {
//       return _instances[searchId - 1];
//     }
  }
}