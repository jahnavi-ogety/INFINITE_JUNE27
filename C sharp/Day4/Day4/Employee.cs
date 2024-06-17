using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Employee
    {
        int Empid;
        string EmpName;
        DateTime DOJ;
        double salary;

        //1.constructor

        public Employee()
        {
            Empid = 10;
            EmpName = "Infinite";
            DOJ = Convert.ToDateTime("2/2/24");
            salary = 50000;

        }

        //  2.constructor
         public Employee(int eid,string name,float sal)
         {
            Empid = eid;
           EmpName = name;
            salary = sal;

         }
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter id,name,sal and DOJ :");
            Empid = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            salary = Convert.ToSingle(Console.ReadLine());
            DOJ = Convert.ToDateTime(Console.ReadLine());
        }
        public void ShowEmpDetails()
        {
            Console.WriteLine($"Employee id{Empid}, Employee name {EmpName}, Employee salary{salary}, date of joining {DOJ} ");
            Console.Read();
        }
    }
    class Emptest
    {
        public static void Main()
        {
            Employee empp = new Employee();
            empp.ShowEmpDetails();
            Console.WriteLine("-------------");
            Employee emp2 = new Employee(22,"janu", 3800);
            
           emp2.ShowEmpDetails();


        }
    }

}
