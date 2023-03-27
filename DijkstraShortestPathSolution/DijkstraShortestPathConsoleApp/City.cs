using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraShortestPathConsoleApp
{
    public class City
    {
        //Current City
        public string CityName { get; set; }
        
        //Dictionary is a <Key, Value> pair
        //Key = City, Value = Distance of Destination from Current City
        public Dictionary<City, int> Destinations { get; set; }
        public int DistanceFromStart { get; set; }
        public bool Visited { get; set; }
        public City(string cityName)
        {
            CityName = cityName;
            Destinations = new Dictionary<City, int>();
            DistanceFromStart = int.MaxValue;
            Visited = false;
        }
    }
}
