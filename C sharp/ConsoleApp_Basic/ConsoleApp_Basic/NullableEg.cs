using System;


namespace ConsoleApp_Basic
{
    class NullableEg
    {
        public static void Nullexp()
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

            // Null coalising can replace the above code
            int? data11 = null;
            int data22 = data1 ?? 0;
            Console.WriteLine(data22);
        }
    }
}
