using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraShortestPathConsoleApp
{
    public class PriorityQueue<T>
    {
        /*
        * A priority queue behaves like a queue, 
        * but with the added feature of each element having a priority value. 
        * The elements are dequeued in order of their priority value, 
        * with the highest priority element dequeued first.
        */

        //Tuple can take upto 8 items
        //In this case, we will have two items:
        //The T class object and an int for the priority
        
        public List<Tuple<T, int>> elements = new List<Tuple<T, int>>();

        public int Count
        {
            get { return elements.Count; }
        }

        public void Enqueue(T item, int priority)
        {
            elements.Add(Tuple.Create(item, priority));
        }

        public T Dequeue()
        {
            int priorityItemIndex = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Item2 < elements[priorityItemIndex].Item2)
                {
                    priorityItemIndex = i;
                }
            }
            T priorityItem = elements[priorityItemIndex].Item1;
            elements.RemoveAt(priorityItemIndex);
            return priorityItem;
        }
    }
}
