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
           

            switch(Daynum)
            {
                case 1:
                    Console.WriteLine("Its Monday, have a great day");
                    break;
                case 2:
                    Console.WriteLine("Its Tuesday,have a great day ");
                    break;
                case 3:
                    Console.WriteLine("Its Wednesday,have a great day");
                    break;
                case 4:
                    Console.WriteLine("Its Thursday,have a great day");
                    break;
                case 5:
                    Console.WriteLine("Its Friday,have a great day");
                    break;
                case 6:
                    Console.WriteLine("Its Saturday,have a great day");
                    break;
                case 7:
                    Console.WriteLine("Its Sunday,have a great day");
                    break;
                default:
                    Console.WriteLine("please try again");
                    break;
                    
            }
            Console.Read();
        }
    }
}
