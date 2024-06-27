using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    

    public class Scholarship
    {
        public decimal Merit(int marks, decimal fees)
        {
            decimal scholarship = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarship = 0.2m * fees; 
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarship = 0.3m * fees; 
            }
            else if (marks > 90)
            {
                scholarship = 0.5m * fees; 
            }
            

            return scholarship;
        }
    }

    public class Program4
    {
        public static void Main()
        {
            Scholarship scholarship = new Scholarship();

            
            int marks1 = 75;
            decimal fees1 = 10000;
            decimal scholarship1 = scholarship.Merit(marks1, fees1);
            Console.WriteLine($"For marks {marks1} the  fees could be {fees1:C},and scholarship amount: {scholarship1:C}");

            int marks2 = 85;
            decimal fees2 = 12000;
            decimal scholarship2 = scholarship.Merit(marks2, fees2);
            Console.WriteLine($"For marks {marks2} the fees could be {fees2:C}, and scholarship amount: {scholarship2:C}");

            int marks3 = 95;
            decimal fees3 = 15000;
            decimal scholarship3 = scholarship.Merit(marks3, fees3);
            Console.WriteLine($"For marks {marks3} the  fees could be {fees3:C}, and scholarship amount: {scholarship3:C}");
            Console.Read();
        }
    }

}
