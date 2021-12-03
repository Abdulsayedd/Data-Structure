using System;
namespace Queuearr
{
    class Queue
    {
        public int head, rear;
        int[] arr;
        public Queue(int size)
        {
            head = rear = -1;
            arr = new int[size];
        }
        public bool is_full()
        {
            return rear == arr.Length - 1;
        }
        public void enqueue(int n)
        {
            if(is_full())
                Console.WriteLine("Queue is full!");
            else
            {
                if(head==-1)
                {
                    head = 0;
                }
                rear++;
                arr[rear] = n;
            }
        }
        public bool is_empty()
        {
            if(rear==-1 || rear<head)
            {
                return true;
            }
            return false;
        }
        public void dequeue()
        {
            if (is_empty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine("dequeue : " + arr[head++]);
        }
        public void peek()
        {
            if (is_empty())
                Console.WriteLine("Queue is empty!");
            else
                Console.WriteLine("peeking at : " + arr[head]);
        }
        public void size()
        {
            Console.WriteLine("size = " + (rear-head+1));
        }
        public void display()
        {
            if (is_empty())
                Console.WriteLine("Queue is empty!");
            else
            {
                for(int i = head; i <= rear; i++)
                {
                    Console.Write(arr[i]+ " " );
                }
                Console.WriteLine();
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size : ");
            int size = int.Parse(Console.ReadLine());
            Queue L = new Queue(size);
            L.enqueue(10);
            L.enqueue(11);
            L.enqueue(12);
            L.enqueue(13);
            L.enqueue(14);
            L.display();
            L.dequeue();
            L.size();
            Console.WriteLine(L.is_empty());
            Console.WriteLine(L.is_full());
            L.dequeue();
            L.dequeue();
            L.dequeue();
            L.dequeue();
            L.dequeue();
            L.dequeue();
        }
    }
}
