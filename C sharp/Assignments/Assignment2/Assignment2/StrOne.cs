using System;


namespace Assignment2
{
    class StrOne

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any  word");
            string st = Console.ReadLine();

            int l = st.Length;
            Console.WriteLine($"The length of the word {st} is :" + ""+ l );
            Console.Read();

        }
    }
}
