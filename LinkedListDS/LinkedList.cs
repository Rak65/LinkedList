using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListDS
{
    class SortedLinkedList<T> where T : IComparable<T>
    {
        private Node<T> head;  // Reference to the first node in the list

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);  // Create a new node with the given data

            if (head == null || data.CompareTo(head.Data) < 0)
            {
                // If the list is empty or the data is smaller than the head node data,
                // make the new node the new head
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null && data.CompareTo(current.Next.Data) > 0)
                {
                    current = current.Next;
                }
                // Insert the new node at the appropriate position in the list
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void Display()
        {
            Node<T> current = head;
            while (current != null)
            {
                // Traverse the list and print the data of each node
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();

        }
        

    }
}
