using System;


namespace ConsoleApp_Basic
{
    class NullableEg
    {
        public static void nullexp()
        {
            int  ? data1 = 600;
            int data2;
            if (data1 == null)
            {
                data2 = 0;
            }
            else
                data2 =(int) data1;
            Console.WriteLine(data2);
        }
    }
}
