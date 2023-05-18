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
            linkedList.Insert(30, 56);  // Insert 30 after the node with value 56
            linkedList.Insert(70, 30);  // Insert 70 after the node with value 30
            linkedList.Display();
            Console .ReadKey();

        }
    }
}
