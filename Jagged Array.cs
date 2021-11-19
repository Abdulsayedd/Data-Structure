using System;

namespace Jagged_Array
{
        class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  the number of rows ");
            int rows = int.Parse(Console.ReadLine());
            int[][] Arr = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                Console.WriteLine("Enter the number of elements in the {0}th row " , i);
                int h = int.Parse(Console.ReadLine());
                Arr[i] = new int[h];
            }
            for(int i = 0; i < Arr.Length; i++)//Read input
            {
                for(int j = 0; j < Arr[i].Length ;j++)
                {
                    Console.Write("Row [{0}] : ", i);
                    Console.WriteLine("Enter {0},{1} Element " , i , j);
                    Arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\n================================\n");
            for(int i = 0; i < Arr.Length; i++)//Output
            {
                Console.Write("Row [{0}] : ",i);
                for(int j = 0; j < Arr[i].Length ;j++)
                {
                    Console.Write(Arr[i][j]+ " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
