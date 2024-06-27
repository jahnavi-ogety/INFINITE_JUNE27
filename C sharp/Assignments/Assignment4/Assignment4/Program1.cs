using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program1
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public static void Display(string fname, string Lname)
        {
            string upper_frstname = fname.ToUpper();
            string upper_Lastname = Lname.ToUpper();
            Console.WriteLine(upper_frstname);
            Console.WriteLine(upper_Lastname);
        }

        public static void Main()
        {
            Program1 p = new Program1();
            Console.WriteLine("Enter First Name:");
            p.First_Name = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            p.Last_Name = Console.ReadLine();

            Display(p.First_Name, p.Last_Name);
            Console.Read();


        }
    }
}      

    

