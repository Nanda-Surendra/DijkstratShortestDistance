using DijkstraShortestPathConsoleApp;

City s = new City("S");
City a = new City("A");
City b = new City("B");
City c = new City("C");
City d = new City("D");
City e = new City("E");

s.Destinations.Add(a, 4);
s.Destinations.Add(b, 2);

a.Destinations.Add(c, 1);
b.Destinations.Add(c, 6);
b.Destinations.Add(d, 5);

c.Destinations.Add(d, 1);
c.Destinations.Add(e, 4);
d.Destinations.Add(e, 1);

DijkstraAlgorithm.FindShortestPath(s, e);
//DijkstraAlgorithm.FindShortestPath(e, s);

City atlanta = new City("Atlanta");
City chicago = new City("Chicago");
City dallas = new City("Dallas");
City newYork = new City("New York");
City boston = new City("Boston");
City seattle = new City("Seattle");
City denver = new City("Denver");


atlanta.Destinations.Add(chicago, 599);
atlanta.Destinations.Add(dallas, 725);
atlanta.Destinations.Add(newYork, 756);

newYork.Destinations.Add(boston, 191);
newYork.Destinations.Add(dallas, 756);

boston.Destinations.Add(newYork, 191);
boston.Destinations.Add(seattle, 2489);

chicago.Destinations.Add(denver, 907);

dallas.Destinations.Add(denver, 650);

DijkstraAlgorithm.FindShortestPath(atlanta, denver);
//DijkstraAlgorithm.FindShortestPath(boston, atlanta);
