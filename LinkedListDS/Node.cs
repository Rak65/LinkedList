using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    class Node<T> where T : IComparable<T>
    {
        public T Data;  // Data stored in the node
        public Node<T> Next;  // Reference to the next node in the list

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
