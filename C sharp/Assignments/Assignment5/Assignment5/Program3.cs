using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    using System;

    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box Add(Box box1, Box box2)
        {
            double L = box1.Length + box2.Length;
            double B = box1.Breadth + box2.Breadth;
            return new Box(L, B);
        }
        public void Display()
        {
            Console.WriteLine($"Box Length: {Length}");
            Console.WriteLine($"Box Breadth: {Breadth}");
        }
    }

    public class Program3
    {
        static void Main()
        {

            Box box1 = new Box(5, 5);
            Box box2 = new Box(8.5, 2.4);  
            Box box3 = Box.Add(box1, box2);
            
            Console.WriteLine("Box 1:");
            box1.Display();
            
            Console.WriteLine("Box 2:");
            box2.Display();
            
            Console.WriteLine("Result of Adding Box 1 and Box 2:");
            box3.Display();
     
            Console.Read();
        }
    }

    
}
