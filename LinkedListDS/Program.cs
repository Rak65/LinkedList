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
            SortedLinkedList<int> sortedList = new SortedLinkedList<int>();

            sortedList.Add(56);
            sortedList.Add(30);
            sortedList.Add(40);
            sortedList.Add(70);
            sortedList.Display();
            Console .ReadKey ();
        }
    }
}
