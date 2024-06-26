using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    abstract class Student
    {
        
        public string Name { get; set; }
        public int Student_Id { get; set; }
        public double Student_Grade { get; set; }

        
        public abstract bool IsPassed(double grade);
    }

    
    class Undergraduate : Student
    {
        
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    
    class Graduate : Student
    {
        
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program1
    {
        static void Main()
        {
           
            
            Undergraduate ug = new Undergraduate
            {
                Name = "Jahnavi",
                Student_Id = 1035,
                Student_Grade = 75.5 
            };

            
            Console.WriteLine($"Undergraduate Student Name: {ug.Name}, Student ID: {ug.Student_Id}");
            Console.WriteLine($"Grade: {ug.Student_Grade}");
            Console.WriteLine($"Result: {(ug.IsPassed(ug.Student_Grade) ? "Passed" : "Failed")}");
            Console.WriteLine();

            
            Graduate gr = new Graduate
            {
                Name = "Swarna",
                Student_Id = 2041,
                Student_Grade = 85.0 
            };

            
            Console.WriteLine($"Graduate Student Name: {gr.Name}, Student_ID: {gr.Student_Id}");
            Console.WriteLine($"Grade: {gr.Student_Grade}");
            Console.WriteLine($"Result: {(gr.IsPassed(gr.Student_Grade) ? "Passed" : "Failed")}");

            Console.ReadLine();
        }
    }

}
