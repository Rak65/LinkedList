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
            linkedList.Add(40);
            linkedList.Add(70);
            linkedList.Display();

            int searchKey = 40;
            Node result = linkedList.Search(searchKey);

            if (result != null)
            {
                Console.WriteLine("Node with value {0} found.", searchKey);
            }
            else
            {
                Console.WriteLine("Node with value {0} not found.", searchKey);
            }

            linkedList.Delete(searchKey);
            linkedList.Display();

            Console.WriteLine("Linked List size: {0}", linkedList.Size());
            linkedList .Display();
            Console .ReadKey();

        }
    }
}
