using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDS
{
    public class LinkedList
    {
        private Node head;  // Reference to the first node in the list
        public void Add(int data)
        {
            Node newNode = new Node(data);  // Create a new node with the given data

            if (head == null)
            {
                // If the list is empty, make the new node the head
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    // Traverse to the end of the list
                    current = current.Next;
                }
                // Add the new node at the end of the list
                current.Next = newNode;
            }
        }

        public void Insert(int data, int afterValue)
        {
            Node newNode = new Node(data);  // Create a new node with the given data

            if (head == null)
            {
                // If the list is empty, make the new node the head
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current != null)
                {
                    // Traverse the list to find the node with the specified value
                    if (current.Data == afterValue)
                    {
                        // Insert the new node after the found node
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        break;
                    }
                    current = current.Next;
                }

                if (current == null)
                {
                    // The specified value was not found in the list
                    Console.WriteLine("Node with value {0} not found.", afterValue);
                }
            }
        }

        public void Display()
            {
                Node current = head;
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
