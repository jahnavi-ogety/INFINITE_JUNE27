using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Concession
{


    public class TicketConcession
    {

        private const int BaseFare = 500;

        public string Name { get; set; }
        public int Age { get; set; }

        public TicketConcession(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void CalculateConcession()
        {
            if (Age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
                DisplayDetails();
            }
            else if (Age > 60)
            {
                double concessionAmount = 0.3 * BaseFare;
                double discountedFare = BaseFare - concessionAmount;

                Console.WriteLine("Senior Citizen - Calculated Fare: " + discountedFare);
                DisplayDetails();
            }
            else
            {
                Console.WriteLine("Ticket Booked - Fare: " + BaseFare);
                DisplayDetails();
            }
        }

        private void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
    class Program4

    {
        static void Main()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = Convert.ToInt32(Console.ReadLine());
            

            TicketConcession ticket = new TicketConcession(name, age);
            ticket.CalculateConcession();

            Console.ReadLine();
        }
    }
}

