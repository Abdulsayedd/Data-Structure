using System;

namespace Bubble_Sort
{
    class Program
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void Print(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
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
            Program S = new Program();
            S.Sort(arr);
            S.Print(arr);
        }
    }
}
