using System;


namespace Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("The two integers are equal");
            }
            else
                Console.WriteLine("The two integers are not equal");
            Console.Read();
        }
       
    }
}
