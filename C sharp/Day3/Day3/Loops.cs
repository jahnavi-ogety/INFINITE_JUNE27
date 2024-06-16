using System;


namespace Day3
{
    class Loops
    {
        public static void WhileLoop()
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public static void DoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public static void ForLoop()
        {
            for(int i=0;i<=5;i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ImplicitExample()
        {
            var mydata = 100;        // data type
            Console.WriteLine(mydata);

            dynamic d;        //reference type
            d = 8;
            d = 'j';
            d = "hello";
            Console.WriteLine(d);
        }
    }
}
