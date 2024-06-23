using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
      public class Student
        { 
        private int rollNo;
        private string name;
        private string className;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        
        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

       
        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            int idx = 0;
            foreach (var subject in marks)
            {
                Console.Write($"Subject {idx + 1}: ");
                marks[idx] = Convert.ToInt32(Console.ReadLine());
                idx++;
            }
        }

        
        public void DisplayResult()
        {
            
            double sum = 0;
            foreach (var mark in marks)
            {
                sum += mark;
            }
            double average = sum / marks.Length;

            
            bool fail = false;
            foreach (var mark in marks)
            {
                if (mark < 35)
                {
                    fail = true;
                    break;
                }
            }

            if (fail || average < 50)
            {
                Console.WriteLine("Result: Fail");
            }
            else
            {
                Console.WriteLine("Result: Pass");
            }

            Console.WriteLine($"Average Marks: {average}");
        }

     
        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");

            int index = 0;
            foreach (var mark in marks)
            {
                Console.WriteLine($"Subject {index + 1}: {mark}");
                index++;
            }
        }

       
        public static void Main(string[] args)
        {
           
            Student student = new Student(10, "Jahnavi", "10th", "Fourth", "Computer Science");
            student.GetMarks();
            student.DisplayData();
            student.DisplayResult();
                Console.ReadLine();
        }
    }

}

