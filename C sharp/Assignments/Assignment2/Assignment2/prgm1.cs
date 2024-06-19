using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class prgm1
    {
        static void Main()
        {
            Console.WriteLine("Enter Integer 1:");
            int n1 = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Integer 2:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int Sum = n1 + n2;

            if(n1.Equals(n2))
            {
                int t1 = Sum * 3;
                Console.WriteLine($"The numbers are same therefore:" + t1);
                   
                    
            }
            else
                Console.WriteLine("The numbers are not same");

            Console.Read();

        }
    }
}
