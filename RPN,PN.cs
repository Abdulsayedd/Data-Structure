using System;
namespace PolishNotation
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
        public int peek()
        {
            if (is_empty())
            {  Console.WriteLine("Stack is empty!");
                return 0; 
            }
            else
                return arr[top];
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
            Console.WriteLine("1.Decode from Reverse Polish Notation \n2.Decode from Polish Notation\n3.Encode to Reverse Polish Notation\n4.Encode to Polish Notation\n5.exit");
            int h = int.Parse(Console.ReadLine());
            while(h!=5)
            {
                if(h==1)
                {
                    Console.WriteLine("Enter the Encoded equation : ");
                    stack L = new stack();
                    L.get_array(100);
                    string x = Console.ReadLine();
                    int ans = 0;
                    foreach (char i in x)
                    {
                        if (Char.IsDigit(i))
                        {
                            L.push(i - 48);
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
                    Console.WriteLine("Answer = " + L.pop());
                    h = int.Parse(Console.ReadLine());
                }
                if(h==2)
                {

                    Console.WriteLine("Enter the Encoded equation : ");
                    stack L = new stack();
                    L.get_array(100);
                    string y = "";
                    string x = Console.ReadLine();
                    int ans = 0;
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] == '+' || x[i] == '-' || x[i] == '/' || x[i] == '*')
                        {
                            L.push(x[i]);
                        }
                        else
                        {
                            y += x[i];
                        }
                    }
                    ans = y[0] - 48;
                    for (int i = 1; i < y.Length; i++)
                    {
                        int f = ans;
                        int l = y[i] - 48;
                        if (L.peek() == '-')
                        {
                            ans = f - l;
                            L.pop();
                        }
                        else if (L.peek() == '+')
                        {
                            ans = f + l;
                            L.pop();
                        }
                        else if (L.peek() == '/')
                        {
                            ans = f / l;
                            L.pop();
                        }
                        else if (L.peek() == '*')
                        {
                            ans = f * l;
                            L.pop();
                        }
                    }
                    Console.WriteLine("Answer = " + ans);
                    h = int.Parse(Console.ReadLine());
                }
                if(h==3)
                {
                    Console.WriteLine("Enter the Normal equation : ");
                    stack L = new stack();
                    string y = "", z = "";
                    string x = Console.ReadLine();
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (Char.IsDigit(x[i]))
                        {
                            y += x[i];
                        }
                        else
                        {
                            z += x[i];
                        }
                    }
                    Console.WriteLine("Your Equation : " + y + z);
                    string n = y + z;
                    /////////////////////////////////
                    //stack L = new stack();
                    L.get_array(100);
                    x = n;
                    int ans = 0;
                    foreach (char i in x)
                    {
                        if (Char.IsDigit(i))
                        {
                            L.push(i - 48);
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
                    Console.WriteLine("Answer = " + L.pop());
                    h = int.Parse(Console.ReadLine());

                }
                if (h == 4)
                {
                    Console.WriteLine("Enter the Normal equation : ");
                    stack L = new stack();
                    L.get_array(100);
                    string y = "", z = "";
                    string x = Console.ReadLine();
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (Char.IsDigit(x[i]))
                        {
                            y += x[i];
                        }
                        else
                        {
                            z += x[i];
                        }
                    }
                    Console.WriteLine("Decoded Equation = "+ z+y);
                    string na = z + y;
                     y = "";
                    x = na;
                    int ans = 0;
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] == '+' || x[i] == '-' || x[i] == '/' || x[i] == '*')
                        {
                            L.push(x[i]);
                        }
                        else
                        {
                            y += x[i];
                        }
                    }
                    ans = y[0] - 48;
                    for (int i = 1; i < y.Length; i++)
                    {
                        int f = ans;
                        int l = y[i] - 48;
                        if (L.peek() == '-')
                        {
                            ans = f - l;
                            L.pop();
                        }
                        else if (L.peek() == '+')
                        {
                            ans = f + l;
                            L.pop();
                        }
                        else if (L.peek() == '/')
                        {
                            ans = f / l;
                            L.pop();
                        }
                        else if (L.peek() == '*')
                        {
                            ans = f * l;
                            L.pop();
                        }
                    }
                    Console.WriteLine("Answer = " + ans);
                    h = int.Parse(Console.ReadLine());
                }
                if(h==5)
                {
                    Console.WriteLine("Bye Bye!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
