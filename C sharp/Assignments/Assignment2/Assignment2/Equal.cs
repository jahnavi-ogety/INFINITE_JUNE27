using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Equal
    {
        public static void Main()
        {
            Console.WriteLine("Enter the First String:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the Secong String:");
            string s1 = Console.ReadLine();

            if(s.Equals(s1))
            
                Console.WriteLine("The Strings are equal");
            else
                Console.WriteLine("The Strings are  not equal");
            Console.Read();



        }
        
    }
}
