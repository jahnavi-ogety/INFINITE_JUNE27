using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    

    class Program3
    {
        static void Main()
        {
            try
            {
                
                Console.Write("Enter any number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                
                PNumb(number);

                
                Console.WriteLine($"The number entered is: {number}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("The  Input was not in a valid integer format,Try again..");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }

            Console.ReadLine();
        }

        static void PNumb(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be negative, Try again!");
            }

            
        }
    }

}

