using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
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

        public Employee(int employeeID, string firstName, string lastName, string title, DateTime dob, DateTime doj, string city)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            DOB = dob;
            DOJ = doj;
            City = city;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            
            empList.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateTime(1984, 11, 16), new DateTime(2011, 6, 8), "Mumbai"));
            empList.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateTime(1984, 8, 20), new DateTime(2012, 7, 7), "Mumbai"));
            empList.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateTime(1987, 11, 14), new DateTime(2015, 4, 12), "Pune"));
            empList.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateTime(1990, 6, 3), new DateTime(2016, 2, 2), "Pune"));
            empList.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateTime(1991, 3, 8), new DateTime(2016, 2, 2), "Mumbai"));
            empList.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateTime(1989, 11, 7), new DateTime(2014, 8, 8), "Chennai"));
            empList.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateTime(1989, 12, 2), new DateTime(2015, 6, 1), "Mumbai"));
            empList.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateTime(1993, 11, 11), new DateTime(2014, 11, 6), "Chennai"));
            empList.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateTime(1992, 8, 12), new DateTime(2014, 12, 3), "Chennai"));
            empList.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateTime(1991, 4, 12), new DateTime(2016, 1, 2), "Pune"));

            // 1. Display a list of all the employees who have joined before 1/1/2015
            var joined = empList.Where(emp => emp.DOJ < new DateTime(2015, 1, 1));
            Console.WriteLine("1. Employees who joined before 1/1/2015:");
            foreach (var emp in joined)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("-------------------");
            Console.ReadLine();

            // 2. Display a list of all the employees whose date of birth is after 1/1/1990
            var dob = empList.Where(emp => emp.DOB > new DateTime(1990, 1, 1));
            Console.WriteLine("2. Employees whose date of birth is after 1/1/1990:");
            foreach (var emp in dob)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();

            // 3. Display a list of all the employees whose designation is Consultant and Associate
            var consultants = empList.Where(emp => emp.Title == "Consultant" || emp.Title == "Associate");
            Console.WriteLine("3. Employees whose designation is Consultant or Associate:");
            foreach (var emp in consultants)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("----------------------------------");
            Console.ReadLine();

            // 4. Display total number of employees
            Console.WriteLine($"4. Total number of employees: {empList.Count}");
            Console.WriteLine("--------------------------------------");
            Console.ReadLine();

            // 5. Display total number of employees belonging to “Chennai”
            var chennaiEmp = empList.Count(emp => emp.City == "Chennai");
            Console.WriteLine($"5. Total number of employees belonging to Chennai: {chennaiEmp}");
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();

            // 6. Display highest employee id from the list
            var highest = empList.Max(emp => emp.EmployeeID);
            Console.WriteLine($"6. Highest Employee ID: {highest}");
            Console.WriteLine("---------------------------------");
            Console.ReadLine();

            // 7. Display total number of employees who have joined after 1/1/2015
            var j= empList.Count(emp => emp.DOJ > new DateTime(2015, 1, 1));
            Console.WriteLine($"7. Total number of employees who joined after 1/1/2015: {j}");
            Console.WriteLine("----------------------------");
            Console.ReadLine();

            // 8. Display total number of employees whose designation is not “Associate”
            var notAssociate = empList.Count(emp => emp.Title != "Associate");
            Console.WriteLine($"8. Total number of employees whose designation is not Associate: {notAssociate}");
            Console.WriteLine("------------------------------------------");
            Console.ReadLine();

            // 9. Display total number of employees based on City
            var employees = empList.GroupBy(emp => emp.City)
                                         .Select(group => new { City = group.Key, Count = group.Count() });
            Console.WriteLine("9. Total number of employees based on City:");
            foreach (var cityGroup in employees)
            {
                Console.WriteLine($"{cityGroup.City}: {cityGroup.Count}");
            }
            Console.WriteLine("------------------------------");
            Console.ReadLine();

            // 10. Display total number of employees based on city and title
            var CityAndTitle= empList.GroupBy(emp => new { emp.City, emp.Title })
                                                 .Select(group => new
                                                 {
                                                     City = group.Key.City,
                                                     Title = group.Key.Title,
                                                     Count = group.Count()
                                                 });
            Console.WriteLine("10. Total number of employees based on City and Title:");
            foreach (var group in CityAndTitle)
            {
                Console.WriteLine($"{group.City}, {group.Title}: {group.Count}");
            }
            Console.WriteLine("---------------------------------------");
            Console.ReadLine();

            // 11. Display total number of employees who is youngest in the list
            var youngestEmp= empList.Min(emp => emp.DOB);
            var youngestEmployees = empList.Where(emp => emp.DOB == youngestEmp);
            Console.WriteLine("11. Youngest employee(s):");
            foreach (var emp in youngestEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
            Console.WriteLine("--------------------------------");
            Console.ReadLine();
        }

    }
}
