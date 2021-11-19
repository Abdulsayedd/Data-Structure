using System;

namespace Single_Linked_List
{
    class Node
    {
        public int data;
        public Node next;
    }
    class List
    {
        public int coun;
        public Node head;
        public List()
        {
            head = null;
            coun = 0;
        }
        public void add_front(int item)
        {
            Node temp = new Node();
            temp.data = item;
            temp.next = head;
            head = temp;
            coun++;
        }
        public void add_back(int item)
        {
            Node temp = new Node();
            temp.data = item;
            if(head==null)
            {
                head = temp;
            }
            Node p = head;
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = temp;
            temp.next = null;
            coun++;
        }
        public void insert_after_value(int item,int search)
        {
            Node p = head;
            while(p.data!=search)
            {
                p = p.next;
            }
            Node temp = new Node();
            temp.data = item;
            temp.next = p.next;
            p.next = temp;
            coun++;
        }
        public void insert_before_value(int item, int search)
        {
            Node p = head;
            while (p.next.data != search)
            {
                p = p.next;
            }
            Node temp = new Node();
            temp.data = item;
            temp.next = p.next;
            p.next = temp;
            coun++;
        }
        public void insert_in_position(int item, int pos)
        {
            Node p = head;
            int p1 = 1;
            while (p1!=pos-1)
            {
                p = p.next;
                p1++;
                
            }
            Node temp = new Node();
            temp.data = item;
            temp.next = p.next;
            p.next = temp;
            coun++;
        }
        public void search(int item)
        {
            Node p = head;
            bool found = false;
            while(p.next!=null)
            {
                if(item == p.data)
                {
                    found = true;
                    break;
                }
                p = p.next;
            }
            if (found)
                Console.WriteLine("Found {0} in the linkedlist ", item);
            else
                Console.WriteLine("Not found in the linked list ");
        }
        public void delete_in_position(int pos)//مش جاي في الميد
        {
            Node p = head;
            int p1 = 1;
            while(p1+1 < pos)
            {
                p = p.next;
                p1++;
            }
            p.next = p.next.next;
            coun--;
        }
        public void delete_by_item(int item)//مش جاي في الميد
        {
            Node p = head;
            int p2 = 1;
            if (p.data == item)
            {
                delete_front();
            }
            else
            {
                while (p.data != item)
                {
                    p = p.next;
                    p2++;
                }
                delete_in_position(p2);
            }
            coun--;
        }
        public void delete_last()//مش جاي في الميد
        {
            Node p = head;
            while (p.next.next!=null)
            {
                p = p.next;
            }
            p.next = null;
            coun--;
        }
        public void delete_front()
        {
            head = head.next;
            coun--;
        }
        public void reverse()
        {
            Node prev = null, current = head, odam = null;
            while(current != null)
            {
                odam = current.next;
                current.next= prev;
                prev = current;
                current = odam;
            }
            head = prev;

        }
        public void print()
        {
            Node p = head;
            while(p.next!=null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.Write(p.data + "\n");
        }
        public void size()
        {
            Console.WriteLine("LinkedList size = {0}",coun );
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
            L.add_front(13);
            L.add_front(14);
            L.add_back(15);
            L.delete_by_item(14);
            L.size();
            L.insert_after_value(999, 15);
            L.insert_in_position(999, 3);
            L.insert_before_value(919, 10);
            L.reverse();
            L.size();
            L.delete_in_position(2);
            L.delete_last();
            L.delete_last();
            L.delete_front();
            L.size();
            L.delete_front();
            L.print();
            L.search(919);
            L.size();
            
        }
    }
    }
