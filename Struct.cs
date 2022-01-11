using System;
namespace Struuct
{
        public struct car
    {
        public int price;
        public string model;
        public string color;
        public string Plate_number;
    }
         class Program
    {
        static void Main(string[] args)
        {
            car C = new car();
            C.model = "Toyota";
            C.price = 5000;
            C.color = "red";
            C.Plate_number = "G W H 1 9 2";
            car C2 = new car();
            C2.model = "porsche";
            C2.price = 1000000;
            C2.color = "yellow";
            C2.Plate_number = "X I 0 0 0";
            Console.WriteLine("Car 1 : ");
            Console.WriteLine("Model: {0}   Price: {1}  Color:  {2}    Plate Number: {3} " , C.model , C.price , C.color , C.Plate_number);  
            Console.WriteLine("Car 2 : ");
            Console.WriteLine("Model: {0}   Price: {1}  Color:  {2}    Plate Number: {3} " , C2.model , C2.price , C2.color , C2.Plate_number);
        }
    }
}
