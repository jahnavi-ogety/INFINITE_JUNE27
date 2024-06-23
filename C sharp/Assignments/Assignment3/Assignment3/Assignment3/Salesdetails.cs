using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Salesdetails
    {
        private int Sales_No;
        private int Product_No;
        private double Price;
        private DateTime data_time;
        private int Quantity;
        private double Total;

        public Salesdetails(int Sno,int ProdNo,double p,int qty,DateTime Dt)
        {
            this.Sales_No = Sno;
            this.Product_No = ProdNo;
            this.Price = p;
            this.Quantity = qty;
            this.data_time = Dt;

            Sales(this.Quantity, this.Price);
        }
        public void Sales(int qty,double p)
        {
            this.Quantity = qty;
            this.Price = p;
            this.Total = this.Quantity * this.Price;
        }

        public void Displaydata()
        {
            Console.WriteLine("Sales Number:" + this.Sales_No);
            Console.WriteLine("Product Number :" + this.Product_No);
            Console.WriteLine("Price :" + this.Price);
            Console.WriteLine("Quantity :" + this.Quantity);
            Console.WriteLine("Date of sale :" + this.data_time.ToShortDateString());
            Console.WriteLine("Total Amount :" + this.Total);
            Console.WriteLine("-----------------------");
        }

        public static void Main()
        {
            Salesdetails sale = new Salesdetails(1, 100, 40.5, 7, DateTime.Today);
                sale.Displaydata();
            sale.Sales(10, 40.34);
            sale.Displaydata();
            Console.ReadLine();
        }

    }
    
    
    
}
