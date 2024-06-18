using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayy5
{
    class Distance
    {
        public static int dist1;
       public int myvariable;

        //constructor
        public Distance(int d)
        {
            dist1 = d;
            myvariable = 0;
        }

        //operator overload function ' ++ '
        public static Distance operator ++(Distance d)
        {
            Distance temp = new Distance();
            dist1 = dist1 + 1;
           //  temp.myvariable = 25;
            return temp;
        }

    }
    class OperatorOverloading
    {
        static void Main()
        {
            Distance d1 = new Distance(50);
            Distance d2 = new Distance(80);
           // d.dist1 = 50;
            //d.dist1 = 80;
            Distance totaldistance = d1++;  // the operator overloaded function is called

            Console.WriteLine("The overall Distance is {0} ans Myvar is {1}", totaldistance.dist1, totaldistance.myvariable);
            totaldistance = d1++;
            Console.WriteLine("The overall Distance after prefix is {0} and Myvar is {1}",totaldistance.dist1,totaldistance.myvariable);

            Console.Read();

        }
    }
}
