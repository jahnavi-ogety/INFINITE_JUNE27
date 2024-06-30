using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    
    public interface IStudent
    {
        
        int StudentId { get; set; }
        string Name { get; set; }

        void ShowDetails();
    }

    public class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        
        public Dayscholar(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Dayscholar - Student ID: {StudentId}, Name: {Name}");
        }
    }
    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Resident(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Resident - Student ID: {StudentId}, Name: {Name}");
        }
    }

    class Program6
    {
        static void Main()
        {
            Console.WriteLine("Enter Dayscholar Student ID:");
            int dayscholarId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Dayscholar Name:");
            string dayscholarName = Console.ReadLine();

            Dayscholar dayscholar = new Dayscholar(dayscholarId, dayscholarName);

            Console.WriteLine("Enter Resident Student ID:");
            int residentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Resident Name:");
            string residentName = Console.ReadLine();
            Resident resident = new Resident(residentId, residentName);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Student Details:");
            dayscholar.ShowDetails();
            resident.ShowDetails();

            Console.Read();
        }
    }

}
