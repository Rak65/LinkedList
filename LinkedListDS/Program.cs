﻿using System;
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

            linkedList.PopLast();  // Delete the Last element
            linkedList.Display();
            Console .ReadKey();

        }
    }
}
