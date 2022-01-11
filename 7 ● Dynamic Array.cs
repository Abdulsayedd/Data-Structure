using System;

namespace Dynamic_Array
{
    class Dynamic
    {
        int[] arr;//main array
        int Last_Index = -1;//last index of numbers
        public void get(int x)//getting the array 
        {
            if(x<=0)
            {
                x = 1;
            }
            arr = new int[x];
        }
        public void Expand()//expanding array size for adding
        {
            int[] arr1 = new int[arr.Length * 2];
            Array.Copy(arr, arr1, arr.Length);
            arr = arr1;
        }
        public void add(int item)//adding elements
        {
            if(Last_Index==arr.Length-1)
            {
                Expand();
            }
            Last_Index++;
            arr[Last_Index] = item;
        }
        public void insertcopy(int pos)//method for insert
        {
            for (int i = Last_Index; i >= pos; i--)
            {
                arr[i + 1] = arr[i];
            }
            Last_Index++;
        }
        public void insert(int item,int pos)//inserting at a certain position
        {
            if (Last_Index == arr.Length - 1)
            {
                Expand();
            }
            insertcopy(pos);
            arr[pos] = item;
        }
        public void find(int item)//searching for item
        {
            bool f = false;
            for (int i = 0; i <= Last_Index; i++)
            {
                if (item == arr[i])
                    f = true;
            }
            if(f)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not Found");
        }
        public void print ()//printing the array
        {
            for(int i = 0; i <= Last_Index; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the initial size of array : ");
            int x = int.Parse(Console.ReadLine());
            Dynamic D = new Dynamic();
            D.get(x);
            D.add(2);
            D.add(3);
            D.add(4);
            D.add(41);
            D.add(164);
            D.insert(9999, 3);
            D.print();
            D.find(4);
        }
    }
    }
