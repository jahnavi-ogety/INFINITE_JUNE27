using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Books
    {
        private string Book_Name;
        private string Author_Name;

        public Books(string b, string a)
        {
            this.Book_Name = b;
            this.Author_Name = a;
        }

        public void Display()
        {
            Console.WriteLine("Book Name :" + Book_Name);
            Console.WriteLine("Author Name:" + Author_Name);

        }
    }
    class Program1
    {
        static void Main()
        {
            Books b1 = new Books("The Secret", "Rhonda Byrne");
            Books b2 = new Books("Wise and otherwise", "SUdha Murthy");


            Console.WriteLine("Book 1:");
            b1.Display();
            Console.WriteLine("Book 2:");
            b2.Display();
            Console.Read();




        }
    }
}
      
    

