using System;

namespace Circular_Linked_List
{
    class Node
    {
        public int data;
        public Node next;
    }
    class List
    {
        public int coun;
        public Node last;
        public List()
        {
            last = null;
            coun = 0;
        }
        public void add_front(int item)
        {
            Node temp = new Node();
            temp.data = item;
            if (last == null)
            {
                last = temp;
            }
            temp.next = last.next;
            last.next = temp;
            coun++;
        }
        public void add_back(int item)
        {
            Node temp = new Node();
            temp.data = item;
            if (last == null)
            {
                last = temp;
            }
                temp.next=last.next;
                last.next = temp;
                last = temp;
                coun++;
        }
        public void delete_first_node()
        {
            if (coun == 1)
            {
                last = null;
                coun--;
            }
            else
            {
                last.next = last.next.next;
                coun--;
            }
        }
        public void delete_last_node()
        {
            if (coun == 1)
            {
                last = null;
                coun--;
            }
            else
            {
                Node p = last;
                while (p.next != last)
                {
                    p = p.next;
                }
                p.next = last.next;
                last = p;
                coun--;
            }
        }
        public void print()
        {
            Node p = last.next;
            while (p != last)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.Write(last.data + "\n");
        }
        public void size()
        {
            Console.WriteLine("LinkedList size = {0}", coun);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List L = new List();
            L.add_back(10);
            L.add_back(11);
            L.add_back(12);
            L.add_back(13);
            L.add_back(14);
            L.add_back(15);
            L.delete_first_node();
            L.delete_last_node();
            L.delete_last_node();
            L.delete_last_node();
            L.delete_last_node();
            L.size();
            L.print();
        }
    }
}
