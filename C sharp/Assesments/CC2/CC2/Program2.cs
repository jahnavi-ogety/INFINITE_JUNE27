using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    

    class Product
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public decimal Product_Price { get; set; }
    }

    class Program2
    {
        static void Main()
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Welcome To The Shop");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("Enter details for Product" + j);
                Product product = new Product();

                
                product.Product_Id = j;
               
                Console.WriteLine("Enter the Product Name: ");
                product.Product_Name = Console.ReadLine();

                bool isValidPrice = false;
                for (int a = 1; a <= 3; a++) 
                {
                    Console.Write("Enter the Price: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price) && price >= 0)
                    {
                        product.Product_Price = price;
                        isValidPrice = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again!!");
                        if (a < 3)
                        {
                            Console.WriteLine($"You have {3 - a} attempts remaining.");
                        }
                    }
                }

                if (!isValidPrice)
                {
                    Console.WriteLine("Maximum attempts reached.");
                    product.Product_Price = 0; 
                }

                
                products.Add(product);
            }


            var sortedProducts = products.OrderBy(p => p.Product_Price);

            
            Console.WriteLine("Sorted Products based on Price Value Given :");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Product ID: {product.Product_Id}, Product Name: {product.Product_Name}, Price: {product.Product_Price:C}");
            }

            Console.ReadLine();
        }
    }



}
