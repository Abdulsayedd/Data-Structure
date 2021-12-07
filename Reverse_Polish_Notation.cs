using System;
namespace ReversePolishNotation
{
    class stack
    {
        public int top;
        public int[] arr;
        public stack()
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
            return top == arr.Length - 1;
        }
        public void push(int n)
        {
            if (is_full())
                Console.WriteLine("Stack Overflow!");
            else
            {
                top++;
                arr[top] = n;
            }

        }
        public int pop()
        {
            if (is_empty())
            {
                Console.WriteLine("Stack Underflow!");
                return 0;
            }
            return arr[top--];
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
                for (int i = top; i >= 0; i--)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            stack L = new stack();
            L.get_array(100);
            string x = Console.ReadLine();
            int ans = 0;
            foreach(char i in x)
            {
                if(Char.IsDigit(i))
                {
                    L.push(i-48);
                }
                else
                {
                    switch (i)
                    {
                        case '+':
                            ans = L.pop() + L.pop();
                            L.push(ans);
                            break;
                        case '-':
                            ans = L.pop() - L.pop();
                            L.push(ans);
                            break;
                        case '*':
                            ans = L.pop() * L.pop();
                            L.push(ans);
                            break;
                        case '/':
                            ans = L.pop() / L.pop();
                            L.push(ans);
                            break;
                    }
                }
            }
            Console.WriteLine(L.pop());
        }
    }
}
