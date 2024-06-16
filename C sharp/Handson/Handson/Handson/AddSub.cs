using System;


namespace Handson
{
    class AddSub
    {
        public static void Main()
        {
            int num1, num2;
            Console.Write("Enter the first number:");
            num1= int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());
            int res;
            Console.Write("Enter the Operator(+,-,*,/):");
            string sign= Console.ReadLine();
            switch(sign)
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
