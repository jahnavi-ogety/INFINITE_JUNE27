using System;


namespace ConsoleApp_Basic
{
    class TypeCasting
    {
        static void Main()
        {
            simpleconv();
            boxing_unboxing();
            Console.Read();
           
        }

        static void boxing_unboxing()
        {
            int x = 200;  //value type
            object obj;    //reference type
            obj = x;   //value type to reference type  boxing
            Console.WriteLine($"The value of {obj}");

            float salary;
            Console.WriteLine("Enter your salary");
            salary = float.Parse(Console.ReadLine());    //reference to value unboxing
        }

        static void simpleconv()
        {
            int i = 100;
            Console.WriteLine("The value of  int " + i);
            float f = i;    //implicit converstion
            Console.WriteLine("The value of float" + f);

            f = 1234.432f;
            i = (int)f;      // explicit converstion
            Console.WriteLine(i);

            //parse 
            string str = "100";
            i = int.Parse(str);

            // Try parse
            str = "100";
            int result = 0;
            bool sucess = int.TryParse(str, out result);
            if (sucess)
            {
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("Error");
        }

    }
}
