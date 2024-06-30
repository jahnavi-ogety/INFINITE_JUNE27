using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public float Salary { get; set; }
        public Employee(int empid, string empname, float salary)
        {
            Empid = empid;
            Empname = empname;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Employee ID: {Empid}");
            Console.WriteLine($"Employee Name: {Empname}");
            Console.WriteLine($"Employee Salary: {Salary}");
        }
    }
    class Program4
    {
        static void Main()
        {
           
            Console.WriteLine("Enter Employee ID:");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            float empSalary = Convert.ToSingle(Console.ReadLine());
            
            Employee emp1 = new Employee(empId, empName, empSalary);

            Console.WriteLine("Employee Details are given below:");
            emp1.Display();
            Console.Read();
        }
    }

}
