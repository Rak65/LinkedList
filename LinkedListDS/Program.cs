using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display(); ;
            //linkedList.Search(30);
            if (linkedList.Search (30) != null)
                Console.WriteLine("Node with value {0} found.", 30);
            else
                Console.WriteLine("Node with value {0} not found.", 30);
            Console .ReadKey();

        }
    }
}
