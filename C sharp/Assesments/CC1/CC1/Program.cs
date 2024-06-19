using System;


namespace CC1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testStrings = { "abcd", "a", "xy" };

            foreach(string input in testStrings)
            {
                string result = ExchangeChar(input);
                Console.WriteLine(result); ;
                Console.Read();

            }

        }
        static string ExchangeChar(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }
            char Char1 = Convert.ToChar(Console.ReadLine());
            char Char2 = [input.Length - 1];

            string char0= input.Substring(1, input.Length - 2);
            string result  = char1 + char0 + char2;
            return result;
            
        }


    }
}
