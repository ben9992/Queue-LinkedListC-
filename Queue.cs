using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Queue
    {
        private Node head;
        private Node end;
        private int itemCount = 0;
        public Queue() { head = end = null; }

        public void Enqueue(int data)//we add an item to the back of the queue
        {
            Node n = new Node(data);
            if (head == null)//if theres nothing in the first place, we make the new node both the head and end of the queue
            {
                head = n;
                end = head;
            }
            else
            {
                end.next = n;
                end = end.next;
            }
            itemCount++;
        }
        public int Dequeue()//we will return the first value that was enqueued in the queue
        {
            if (head == null)
            {
                throw new IndexOutOfRangeException(); //if theres no head of in the queue
            }
            else
            {
                Node tmp = head;
                int val = tmp.data;
                head = head.next;
                tmp = null;
                itemCount--;
                return val;
            }
        }
        public void DisplayQueue()//to display the items of the queue in order, we dequeue and write
        {//this function also tests our Dequeuing function
            int i = 0;
            while (i <= itemCount)
            {
                Console.Write("{0} ", Dequeue());
                if (i == itemCount)
                {
                    break;
                }
            }
        }
    }
}