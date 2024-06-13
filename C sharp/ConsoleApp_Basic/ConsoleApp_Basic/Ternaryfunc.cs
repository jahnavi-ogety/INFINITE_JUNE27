using System;


namespace ConsoleApp_Basic
{
    class Ternaryfunc
    {
        static void  Main()
        {
            
            int num = 10;
            bool b;
            if (num == 10)
            {
                b = true;
            }
            else
                b = false;
            Console.WriteLine(b);

            //using ternary func
            b = num == 10 ? true : false;
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
