using System;


namespace ConsoleApp_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c sharp");
            Console.WriteLine("Enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lname = Console.ReadLine();
            Console.WriteLine($"your first name is {fname} and last name is {lname}");
            

            // to call the non static func we need to create obj and call the func
            Program prgm = new Program();
            prgm.Display("jahnavi");
            

            // to call an static func we dont need to create an obj
            int sum = Addno(5, 6);
            Console.WriteLine(sum);
            NullableEg.Nullexp();
            Console.Read();

            

        }
        void Display (String username)  // func declaration
        {
            Console.WriteLine("welcome" + username);     // func def
        }


       static  int Addno(int n1, int n2)
        {
            return n1 + n2;
        }
    }


}
