﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int, string> ll = new LinkedList<int, string>();
            ll.AddNodeFirst(0, "a");
            ll.AddNodeLast(3, "e");
            ll.AddNodeLast(1, "b");
            ll.AddNodeLast(2, "c");

            foreach (string value in ll)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("/*******************/");

            var deleteNode = new Node<int, string>(1, "b", null);
            ll.DeleteNode(deleteNode.Key);
            foreach (string value in ll)
            {
                Console.WriteLine(value);
            }
            
        }
    }
}
