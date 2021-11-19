using System;

namespace Symmetric_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int x = int.Parse(Console.ReadLine());
            int[] arr = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter the {0} element : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            bool symmetric = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    symmetric= false;
                    break;
                }
            }
            if(symmetric)
                 Console.WriteLine("Symmetric"); 
            else
                Console.WriteLine("Not Symmetric");
        }
    }
    }
