using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Arr1
    {
        public static void Main()
        {
            int[] Array1 = { 2, 4, 6, 8, 9 };

            int[] Array2 = new int[Array1.Length];
            for(int j=0;j< Array1.Length;j++)
            {
                Array2[j] = Array1[j];
            }

            Console.WriteLine("Elements of the destination Arrays are :");
            foreach(var item in Array2)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
