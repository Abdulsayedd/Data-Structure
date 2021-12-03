using System;

//Enqueue : add an element from the back of the list.
//Dequeue : delete an element from the beggining of the list.
namespace Queue
{
    class Node
    {
        public int data;
        public Node next;
    }
    class List
    {
        public Node head,rear;
        public List()
        {
            head=rear= null;
        }
        public void enqueue(int item)
        {
            Node temp = new Node();
            temp.data = item;
            if (head == null)
            {
                head = rear = temp;
            }
            else
            {
                rear.next = temp;
                rear = temp;
                temp.next = null;
            }
        }
        public void dequeue()
        {
            if (is_empty())
                Console.WriteLine("Empty queue!");
            else
            {
                Console.WriteLine("dequeue : " + head.data);
                head = head.next;
            }
        }
        public bool is_empty()
        {
            return head == null;
        }
        public void display()
        {
            Node p = head;
            while (p.next != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.Write(p.data + "\n");
        }
        public void peek()
        {
            if (is_empty())
                Console.WriteLine("Empty queue!");
            else
                Console.WriteLine("peek at : " + head.data);
        }
        public void size()
        {
            Node p = head;
            int coun = 1;
            while(p!=rear)
            {
                coun++;
                p = p.next;
            }
            Console.WriteLine("LinkedList size = {0}", coun);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List L = new List();
            L.enqueue(10);//10
            L.enqueue(11);//10 11
            L.enqueue(12);//10 11 12
            L.enqueue(13);//10 11 12 13
            L.enqueue(14);//10 11 12 13 14
            L.enqueue(15);//10 11 12 13 14 15
            L.display();//10 11 12 13 14 15 
            L.dequeue();//11 12 13 14 15
            L.dequeue();//12 13 14 15
            L.dequeue();//13 14 15
            L.peek();//13
            L.size();//3
            L.display();//13 14 15
            L.dequeue();//14 15
            L.dequeue();//15 
            L.dequeue();//
            L.dequeue();// empty!!!
        }
    }
}
