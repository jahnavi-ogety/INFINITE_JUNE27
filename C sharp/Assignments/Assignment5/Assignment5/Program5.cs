using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Employee1
    {
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public float Emp_Salary { get; set; }
        public Employee1(int empid, string empname, float salary)
        {
            Emp_id = empid;
            Emp_name = empname;
            Emp_Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee ID:" + Emp_id);
            Console.WriteLine($"Employee Name:" + Emp_name);
            Console.WriteLine($"Employee Salary:" + Emp_Salary);
        }
    }

    public class ParttimeEmployee : Employee1
    {
        public float Wages { get; set; }

        public ParttimeEmployee(int empid, string empname, float salary, float wages)
            : base(empid, empname, salary)
        {
            Wages = wages;
        }
        public  void Display() 
        {
            base.Display();
           
            Console.WriteLine($"Part-time Employee Wages are: {Wages}");
        }
    }

    class Program5
    {
        static void Main()
        {
            
            Console.WriteLine("Enter Employee ID:");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            float empSalary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Part-time Employee Wages:");
            float empWages = Convert.ToSingle(Console.ReadLine());

            
            ParttimeEmployee p_Emp = new ParttimeEmployee(empId, empName, empSalary, empWages);

            Console.WriteLine("---------------------------");
            Console.WriteLine("The Part-time Employee Details are given below:");
            p_Emp.Display();

            Console.Read();
        }
    }

}
