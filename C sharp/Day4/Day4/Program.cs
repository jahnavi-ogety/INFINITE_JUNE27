using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
          // Stringops();
           //Enumerations.EnumOp();
            
            Employee emp = new Employee();
            emp.GetEmployeeDetails();
            emp.ShowEmpDetails();
            Console.Read();


        }
        public static void Stringops()
        {
            string s = "Hello";
            Console.WriteLine("S for the first time is {0}",s.GetHashCode());
            s = "Hello world";
            Console.WriteLine("S after change is {0}", s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine("S1 {0}", s1.GetHashCode());

            string s2 = s1;
            Console.WriteLine("s2 {0}", s2.GetHashCode());

            string s3 ="Hello";
            Console.WriteLine("s2 {0}", s3.GetHashCode());
            

            //mutable string-- string builder
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("sb's hash code: {0}", sb.GetHashCode());
            sb.Append("world");
            Console.WriteLine("sb's hash code: {0}", sb.GetHashCode());
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        
    
    public static void StructClass()
    {
        Student S1 = new Student();
        // Student s1=new Student();
        S1.marks1 = 50;
        S1.marks2 = 60;

        Console.WriteLine(S1.marks1 + S1.marks2);

        Student S2 = new Student();
        S2 = S1;
        Console.WriteLine(S2.marks1 + S2.marks2);

        //lets change the value of stud

        S1.marks1 = 80;
        S2.marks1 = 80;
        Console.WriteLine(S1.marks1 + S1.marks2);
        Console.WriteLine(S2.marks1 + S2.marks2);
    }

    }
    struct Student
    {
        public int marks1;
        public int marks2;
    }
}
