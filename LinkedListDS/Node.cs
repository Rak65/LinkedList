using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    public class Node
    {
        public int Data;  // Data stored in the node
        public Node Next;  // Reference to the next node in the list

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
