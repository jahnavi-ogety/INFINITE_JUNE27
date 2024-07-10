using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{
    public delegate int Calc(int i, int j);
    class Program2
    {
        static void Main(string[] args)
        {
            Calc addition = Add;
            Calc subtraction = Sub;
            Calc multiplication = Multiply;

            Console.WriteLine("-------- Calculator --------");
            Console.Write("Enter the first integer: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int n2 = int.Parse(Console.ReadLine());

            int resultAdd = addition(n1, n2);
            Console.WriteLine($"Addition: {n1} + {n2} = {resultAdd}");

            int resultSub = subtraction(n1, n2);
            Console.WriteLine($"Subtraction: {n1} - {n2} = {resultSub}");

            int resultMultiplication = multiplication(n1, n2);
            Console.WriteLine($"Multiplication: {n1} * {n2} = {resultMultiplication}");

            Console.ReadLine(); 

        }

        static int Add(int i, int j)
        {
            return i + j;
        }

        static int Sub(int i, int j)
        {
            return i - j;
        }

        static int Multiply(int i, int j)
        {
            return i * j;
        }
    }
}
