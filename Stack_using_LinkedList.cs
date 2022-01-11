using System;
namespace StackLL
{
    class Node
    {
        public int data;
        public Node next;
    }
    class List
    {
        public int top;
        public Node head;
        public List()
        {
            head = null;
            top = -1;
        }
        public void push(int item)
        {
            Node temp = new Node();
            temp.data = item;
            temp.next = head;
            head = temp;
            top++;
        }
        public void pop()
        {
            if(is_empty())
            {
                Console.WriteLine("Empty Stack");
                return ;
            }
            Console.WriteLine(head.data);
            head = head.next;
            top--;
        }
        public bool is_empty()
        {
            return top<0;
        }
        public void peek()
        {
             Console.WriteLine(head.data);
        }
        public void display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
        public void size()
        {
            Console.WriteLine("Stack size = {0}", (top+1));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List L = new List();
            if (L.is_empty())
            { Console.WriteLine("Empty Stack"); }
            L.push(10);
            L.push(11);
            L.push(12);
            L.peek();
            L.size();
            L.pop();
            L.is_empty();
            L.display();
        }
    }
}
