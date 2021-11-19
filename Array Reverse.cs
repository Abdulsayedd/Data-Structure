using System;

namespace Reverse
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
            int[] reversed_array = new int[x];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed_array[i] = arr[arr.Length - i - 1];
            }
            for (int i = 0; i < reversed_array.Length; i++)
            {
                Console.Write(reversed_array[i] + " ");
            }
        }
    }
    }
