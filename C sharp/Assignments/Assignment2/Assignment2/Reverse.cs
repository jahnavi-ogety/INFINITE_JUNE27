using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Reverse
    {
        public static void  Main()
        {

            Console.WriteLine("Enter any word");
            string str =   Console.ReadLine();

            string reverse = string.Empty;

            for(int j=str.Length-1; j>=0;j--)
            {
                reverse += str[j];
            }
            Console.WriteLine("The Reverse String is : " + reverse);
            Console.ReadLine();
        }
        

    }
}
