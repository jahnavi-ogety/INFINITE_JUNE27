using System;


namespace Handson
{
    class SwapNum
    {
        public static void Main ()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before swapping: a={a},b={b}");
            a = a + b; //a= 15
            b = a - b;  //b=5
            a = a - b;  //a=10
            Console.WriteLine($"After swapping: a={a},b={b}");
            Console.Read();

        }
    }
}
