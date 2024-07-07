using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public decimal EmpSalary { get; set; }
    }
    class Program_3
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { EmpId = 1, EmpName = "Jahnavi", EmpCity = "Bangalore", EmpSalary = 80000 },
            new Employee { EmpId = 2, EmpName = "Hamsa", EmpCity = "Chennai", EmpSalary = 60000 },
            new Employee { EmpId = 3, EmpName = "Uday", EmpCity = "Bangalore", EmpSalary = 45000 },
            new Employee { EmpId = 4, EmpName = "Sunny", EmpCity = "Delhi", EmpSalary = 55000 },
            new Employee { EmpId = 5, EmpName = "Revathi", EmpCity = "pune", EmpSalary = 70000 }
        };
            Console.WriteLine("All Employees:");
            DisplayEmployees(employees);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Employees with Salary > 45000:");
            DisplayEmployees(employees.Where(e => e.EmpSalary > 45000).ToList());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Employees from Bangalore:");
            DisplayEmployees(employees.Where(e => e.EmpCity == "Bangalore").ToList());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Employees sorted by Name (Ascending):");
            DisplayEmployees(employees.OrderBy(e => e.EmpName).ToList());
            Console.Read();
        }
        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"EmpId: {emp.EmpId}, EmpName: {emp.EmpName}, EmpCity: {emp.EmpCity}, EmpSalary: {emp.EmpSalary}");
            }
        }
    }
    
}
