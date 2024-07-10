using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CC4
{
    class File
    {
        static void Main()
        {
            Console.WriteLine("-------- File --------");

            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            Console.Write("Enter the text to append: ");
            string text = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(text);
                }

                Console.WriteLine("Text appended to the file successfully...");
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
                Console.ReadLine();

            }
        }
    }
}
