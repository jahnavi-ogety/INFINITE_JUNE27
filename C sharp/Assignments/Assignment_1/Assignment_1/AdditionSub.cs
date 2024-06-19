using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class AdditionSub
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter the first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());
            int res;
            Console.Write("Enter the Operator(+,-,*,/):");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine(res);
                    break;
                case "-":
                    res = num1 - num2;
                    Console.WriteLine(res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine(res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine(res);
                    break;


            }
            Console.Read();

        }
    }
}

