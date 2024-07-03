using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double l, double b)
        {
            Length = l;
            Breadth = b;
        }
        public static Box Add(Box box1, Box box2)
        {
            double n1 = box1.Length + box2.Length;
            double n2 = box1.Breadth + box2.Breadth;
            return new Box(n1, n2);
        }

        public void Display()
        {
            Console.WriteLine($"Length and Breadth of the Box - Length: {Length}, Breadth: {Breadth}");
        }
    }

    public class Program2_Test
    {
        public static void Main()
        {
            Console.WriteLine("Length and Breath of  Box 1:");
            Console.Write("Length: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());


            Box box1 = new Box(length1, breadth1);

            Console.WriteLine("Length and Breath of Box 2:");
            Console.Write("Length: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());

            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("Details of Box 3:");
            box3.Display();
            Console.Read();
        }
    }
}

