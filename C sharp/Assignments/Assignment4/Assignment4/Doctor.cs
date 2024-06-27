using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Doctor
    {
        private string name;
        private double feesCharged;
        private int regNo;

        public int RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Feesch
        {
            get { return feesCharged; }
            set { feesCharged = value; }
        }





        public Doctor(string name, double feesCharged, int regNo)
        {
            RegNo = regNo;
            Name = name;
            Feesch = feesCharged;
        }

        public void Display()
        {
            Console.WriteLine("Doctor Details:");
            Console.WriteLine("Reg Num : " + RegNo);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Fees charged:" + feesCharged);

        }
    }




    class Program
    {


        static void Main(string[] args)
        {
            Doctor d = new Doctor("Dr.Mohan", 300, 143);
            d.Display();
            

            
            Console.ReadLine();
        }
    }
}
    

