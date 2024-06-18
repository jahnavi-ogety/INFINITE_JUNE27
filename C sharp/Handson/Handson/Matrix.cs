using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    class Matrix
    {
        public static void  Main()
        {
            int number;
            Console.WriteLine("Enter a digit :");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.Write(" ");
            Console.Write(number);
            Console.WriteLine();

            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine();
            

            Console.WriteLine("{0} {0} {0} {0}",number);
            Console.WriteLine("{0}{0}{0}{0}",number);
            
            Console.Read();


        }
    }
}
