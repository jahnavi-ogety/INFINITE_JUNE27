using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class ParamEx
    {
        public static void Main()
        {
           ParamEx eg = new ParamEx();
            int result=eg.addElem();
            Console.WriteLine("The total is : {0}", result);
            result = eg.addElem(4);
            Console.WriteLine("The total is : {0}", result);
            result = eg.addElem(2, 3, 7, 8, 4, 5);
            Console.WriteLine("The total is : {0}", result);
            add(2,3.6f);
            add(3, 3.6f, 34.45, 23.77, 66.89);

            


            Console.Read();
            
        }

        public int addElem(params int[]arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
            

        }

        public static void add(int x, float f, params double[] d)
        {
            Console.WriteLine("{0} , {1}",x,f);
            Console.WriteLine("there are {0} number of elements inthe array",d.Length);
            foreach(double db1 in d)
            {
                Console.WriteLine(db1);

            }
        }
    }
}
