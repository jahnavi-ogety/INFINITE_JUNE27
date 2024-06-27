using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    using System;

    class Program2
    {
        static void Main()
        {
            
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char ch = Console.ReadLine()[0]; 

            
            int count = CountOccurrences(s, ch);
            Console.WriteLine($"The letter '{ch}' appears {count} times in the string.");
            Console.Read();
        }

        
        static int CountOccurrences(string s, char c)
        {
            int count = 0;

            foreach (char ch in s)
            {
                if (char.ToUpper(c) == char.ToUpper(ch))
                {
                    count++;
                }
            }

            return count;
        }
    }

   
}
