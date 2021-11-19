using System;

namespace DD_ARRAY
{
        class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the number of rows ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  the number of columns ");
            int columns = int.Parse(Console.ReadLine());
            int[,] Arr = new int[rows, columns];
            for(int i = 0; i < Arr.GetLength(0); i++)//Read input
            {
                for(int j = 0; j < Arr.GetLength(1);j++)
                {
                    Console.WriteLine("Enter {0},{1} Element " , i , j);
                    Arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < Arr.GetLength(0); i++)//Print output
            {
                for(int j = 0; j < Arr.GetLength(1);j++)
                {
                    Console.Write(Arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
