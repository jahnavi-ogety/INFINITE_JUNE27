using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC4
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }

    class Program3

    {
        static void Main()
        {

            List<Employee> empList = new List<Employee>
        {
            new Employee { EmployeeID = 1001, FirstName = "malcolm", LastName = "daruwalla", Title = "manager", DOB = DateTime.Parse("11/16/1984"), DOJ = DateTime.Parse("06/08/2011"), City = "Mumbai" },
            new Employee { EmployeeID = 1002, FirstName = "asdin", LastName = "dhalla", Title = "AsstManager", DOB = DateTime.Parse("08/20/1984"), DOJ = DateTime.Parse("07/07/2012"), City = "Mumbai" },
            new Employee { EmployeeID = 1003, FirstName = "madhavi", LastName = "oza", Title = "consultant", DOB = DateTime.Parse("11/14/1987"), DOJ = DateTime.Parse("04/12/2015"), City = "Pune" },
            new Employee { EmployeeID = 1004, FirstName = "saba", LastName = "shaikh", Title = "SE", DOB = DateTime.Parse("06/03/1990"), DOJ = DateTime.Parse("2/02/2016"), City = "Pune" },
            new Employee { EmployeeID = 1005, FirstName = "nazia", LastName = "shaikh", Title = "SE", DOB = DateTime.Parse("03/08/1991"), DOJ = DateTime.Parse("02/02/2016"), City = "Mumbai" },
            new Employee { EmployeeID = 1006, FirstName = "amit", LastName = "pathak", Title = "consultant", DOB = DateTime.Parse("11/07/1989"), DOJ = DateTime.Parse("08/10/2023"), City = "Chennai" },
            new Employee { EmployeeID = 1007, FirstName = "vijay", LastName = "natarajan", Title = "consultant", DOB = DateTime.Parse("12/02/1989"), DOJ = DateTime.Parse("08/08/2014"), City = "Mumbai" },
            new Employee { EmployeeID = 1008, FirstName = "rahul", LastName = "dubey", Title = "Associate", DOB = DateTime.Parse("11/11/1983"), DOJ = DateTime.Parse("06/01/2015"), City = "Chennai" },
            new Employee { EmployeeID = 1009, FirstName = "suresh", LastName = "mistry", Title = "Associate", DOB = DateTime.Parse("08/12/1992"), DOJ = DateTime.Parse("12/03/2014"), City = "Chennai" },
            new Employee { EmployeeID = 1010, FirstName = "sumit", LastName = "shah", Title = "manager", DOB = DateTime.Parse("12/04/1991"), DOJ = DateTime.Parse("1/02/2016"), City = "Pune" }
        };

            Console.WriteLine("-------- Employee Details --------");

            
            Console.WriteLine("a. Details of all employees:");
            DisplayEmployees(empList);

            Console.WriteLine("b. Details of employees not located in Mumbai:");
            var employeesNotInMumbai = empList.Where(emp => emp.City != "Mumbai");
            DisplayEmployees(employeesNotInMumbai);

            Console.WriteLine("c. Details of employees with title 'AsstManager':");
            var asstManagers = empList.Where(emp => emp.Title == "AsstManager");
            DisplayEmployees(asstManagers);

            Console.WriteLine("d. Details of employees whose Last Name starts with 'S':");
            var employeesWithSLastName = empList.Where(emp => emp.LastName.StartsWith("S"));
            DisplayEmployees(employeesWithSLastName);
        }

        static void DisplayEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {


                Console.WriteLine($"EmployeeID: {employee.EmployeeID}, " +
                    $"FirstName: {employee.FirstName}, " +
                    $"LastName: {employee.LastName}, " +
                    $"Title: {employee.Title}, " +
                    $"DOB: {employee.DOB.ToShortDateString()}, " +
                    $"DOJ: {employee.DOJ.ToShortDateString()}, " +
                    $"City: {employee.City}");
                Console.ReadLine();
            }
        }
    }
}