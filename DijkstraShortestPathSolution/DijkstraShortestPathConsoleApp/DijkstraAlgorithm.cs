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
            start.DistanceFromStart = 0;
            PriorityQueue<City> cityQueue = new PriorityQueue<City>();
            cityQueue.Enqueue(start, 0);
            
            while (cityQueue.Count > 0) 
            {
                City currentCity = cityQueue.Dequeue();

                //what do we do when we reach the end city?
                if(currentCity == end)
                {  break; }

                currentCity.Visited = true;

                foreach(KeyValuePair<City, int> eachDestination in currentCity.Destinations) 
                {                        
                    int newDistanceFromStart = currentCity.DistanceFromStart + eachDestination.Value;
                    
                    if (!eachDestination.Key.Visited)
                    {
                        eachDestination.Key.Visited = true;
                        eachDestination.Key.DistanceFromStart = newDistanceFromStart;

                        cityQueue.Enqueue(eachDestination.Key, newDistanceFromStart); 
                    }
                    else
                    {
                        if ((currentCity.DistanceFromStart + eachDestination.Value)
                            < eachDestination.Key.DistanceFromStart)
                        {
                            eachDestination.Key.DistanceFromStart = newDistanceFromStart;

                            cityQueue.Enqueue(eachDestination.Key, newDistanceFromStart);                             
                        }
                    }
                }//for each Destination from Current City

            }//end while - as long as there are cities in the queue

            if (end.DistanceFromStart == int.MaxValue)
            {
                Console.WriteLine("No path from {0} to {1}", start.CityName, end.CityName);
            }
            else
            {
                Console.WriteLine("Shortest distance from {0} to {1} is {2}",
                    start.CityName, end.CityName, end.DistanceFromStart);
            }
        }//end FindShortestPath method

    }//end class
}//end namespace
