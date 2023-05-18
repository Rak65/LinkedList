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

        public Node Search(int key)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == key)
                {
                    // Found the node with the key
                    return current;
                }
                current = current.Next;
            }
            // Node with the key not found
            return null;
        }

        public void Delete(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty. Cannot perform delete operation.");
                return;
            }

            if (head.Data == key)
            {
                // If the head node has the key value, delete the head node
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != key)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                // If the node with the key value is found, delete it
                current.Next = current.Next.Next;
            }
            else
            {
                Console.WriteLine("Node with value {0} not found.", key);
            }
        }

        public int Size()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
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
