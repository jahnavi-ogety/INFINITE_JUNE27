using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Cust_Name { get; set; }
        public int Cust_Age { get; set; }
        public string Cust_Phno { get; set; }
        public string Cust_City { get; set; }

        public Customer()
        {
            CustomerId = 0;
            Cust_Name = " ";
            Cust_Age = 0;
           Cust_Phno = " "; 
            Cust_City = " ";
        }

        public Customer(int CustId ,string name,int age,string phone,string city)

        {
            CustomerId = CustId;
            Cust_Name = name;
            Cust_Age = age;
            Cust_Phno = phone;
            Cust_City = city;
        }
        public static void Display_Customer(Customer customer)
        {
            Console.WriteLine( "Customer Id :" + customer.CustomerId);
            Console.WriteLine("Customer Name :" + customer.Cust_Name);
            Console.WriteLine("Customer Age :" + customer.Cust_Age);
            Console.WriteLine("Phone:" + customer.Cust_Phno);
            Console.WriteLine("Customer City:" + customer.Cust_City);
            

        }
        ~Customer()
        {
            Console.WriteLine("Deleting Customer" + CustomerId + ":" +  Cust_Name);
        }


    
    
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1, "jahnavi", 23,"912137882",  "Banglore");
            Display_Customer(c1);

            c1 = null;
            GC.Collect();
            Console.ReadLine();
        
            
            
        }
    }
}
