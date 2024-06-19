using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class PostiveNeg
    {
        public static void Main()
        {

            Console.WriteLine("Enter the number");
            int numb = int.Parse(Console.ReadLine());
            string result;




            result = (numb > 0) ? "Positive number" : "Negative number";
            Console.WriteLine(result);
            Console.Read();



        }
    }
}

