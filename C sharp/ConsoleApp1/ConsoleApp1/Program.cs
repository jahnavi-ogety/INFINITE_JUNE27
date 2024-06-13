using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable.nullExp();
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            String age = Console.ReadLine();

        }

        bool ternaryfunc()
        {
            int num = 10;
            bool b;
            if(num==10)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        
    }
}
