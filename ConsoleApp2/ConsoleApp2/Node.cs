using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
class Node//this node class will be used for both the queue and linked list classes
    {
        public int data { get; set; }
        public Node next { get; set; }
 
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
