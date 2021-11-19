using System;

namespace Binary_Search
{

    class Program
    {
        public void Sort(int[] arr, int size, int find)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public void bs1(int size, int[] arr, int find)
        {
            int s = 0, e = size - 1;
            bool h = false;
            while (s <= e)
            {
                int mid = (s + e) / 2;
                if (arr[mid] == find)
                {
                    h = true;
                    break;
                }
                else if (arr[mid] > find)
                {
                    e = mid - 1;
                }
                else
                {
                    s = mid + 1;
                }
            }
            if (h)
            {
                Console.WriteLine("Found");

            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int x = int.Parse(Console.ReadLine());
            int[] arr = new int[x + 10];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter the {0} element : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the number to find : ");
            int k = int.Parse(Console.ReadLine());
            Program S = new Program();
            S.Sort(arr, x, k);
            S.bs1(x, arr, k);//Found Bool
        }
    }
}
