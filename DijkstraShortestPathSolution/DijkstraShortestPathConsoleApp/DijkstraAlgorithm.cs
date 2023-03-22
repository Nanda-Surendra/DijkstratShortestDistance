using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraShortestPathConsoleApp
{
    public class DijkstraAlgorithm
    {
        public static void FindShortestPath(City start, City end)
        {
            Console.WriteLine("Shortest distance from {0} to {1} is {2}", start.CityName, end.CityName, end.DistanceFromStart);
        }
    }
}
