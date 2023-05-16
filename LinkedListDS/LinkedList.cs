using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    public class LinkedList
    {
        public static void Add()
        {
            LinkedList<int> linked = new LinkedList<int>();
            linked.AddFirst(56);
            linked.AddLast(30);
            linked.AddLast(70);

            foreach (var input in linked)
            {
                Console.WriteLine(input);
            }
        }
    }
}
