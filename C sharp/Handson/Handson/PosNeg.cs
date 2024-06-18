using System;


namespace Handson
{
    class PosNeg
    {
        public static void  Main()
        {
            
            Console.WriteLine("Enter the number");
            int numb = int.Parse(Console.ReadLine());
            string result;


            

            result = (numb > 0) ? "Positive number" : "Negative number";
            Console.WriteLine(result);
            Console.Read();
            


        }
    }
}
