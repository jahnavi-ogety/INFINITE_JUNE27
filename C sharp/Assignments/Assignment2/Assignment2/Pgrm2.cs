using System;


namespace Assignment2
{
    class Pgrm2
    {
        public static void Main()
        {
            int Daynum;
            Console.WriteLine("Enter a Day Number which is equivalent to day name");
            Daynum = Convert.ToInt32(Console.ReadLine());
           Console.ReadLine();

            switch(Daynum)
            {
                case 1:
                    Console.WriteLine("Its Monday");
                    break;
                case 2:
                    Console.WriteLine("Its Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Its Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Its Thursday");
                    break;
                case 5:
                    Console.WriteLine("Its Friday");
                    break;
                case 6:
                    Console.WriteLine("Its Saturday");
                    break;
                case 7:
                    Console.WriteLine("Its Sunday");
                    break;
                default:
                    Console.WriteLine("please try again");
                    break;
                    
            }
        }
    }
}
