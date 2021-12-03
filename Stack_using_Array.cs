using System;
namespace Stackarr
{
    class stack
    {
        public int top;
        public int[] arr;
        public stack ()
        {
            top = -1; 
        }
        public void get_array(int size)
        {
            while (size < 1)
            {
                Console.WriteLine("Enter Valid Size = ");
                size = int.Parse(Console.ReadLine());
                get_array(size);
            }
            arr = new int[size];
        }
        public bool is_empty()
        {
            return top < 0;
        }
        public bool is_full()
        {
            return top == arr.Length-1;
        }
        public void push(int n)
        {
            if(is_full())
                Console.WriteLine("Stack Overflow!");
            else
            {
                top++;
                arr[top] = n;
            }

        }
        public void pop()
        {
            if (is_empty())
                Console.WriteLine("Stack Underflow!");
            else
            {
                Console.WriteLine("Pop : "+arr[top]);
                top--;
            }
        }
        public void peek()
        {
            if (is_empty())
                Console.WriteLine("Stack is empty!");
            else
                Console.WriteLine("the top element in the stack is " + arr[top]);
        }
        public int size()
        {
            if (is_empty())
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
            else
                return top + 1;
        }
        public void display()
        {
            if (is_empty())
                Console.WriteLine("Stack is empty!");
            else
            {
                for(int i = top; i >=0;i--)
                    Console.Write(arr[i]+" ");
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stack L = new stack();
            Console.WriteLine("Enter the size of stack :");
            int size = int.Parse(Console.ReadLine());
            L.get_array(size);
            if (L.is_empty())
            { Console.WriteLine("Empty Stack"); }
            L.push(10);
            L.push(11);
            L.push(12);
            L.push(13);
            L.push(14);
            L.push(15);
            L.peek();
            Console.WriteLine("size = " +L.size()); 
            L.pop();
            L.pop();
            L.pop();
            L.is_empty();
            L.push(10);
            L.push(11);
            L.push(12);
            L.push(10);
            L.push(11);
            L.push(12);
            L.display();
        }
    }
}
