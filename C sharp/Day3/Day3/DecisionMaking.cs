using System;


namespace Day3
{
    class DecisionMaking
    {
        public static void Checkgrade()
        {
            char grade;
            Console.WriteLine("Enter the grade");
            grade = Convert.ToChar(Console.ReadLine());
            if(grade=='O' || grade=='o')
            
                Console.WriteLine("Excellent");
             else if (grade == 'A' || grade == 'a')
                    Console.WriteLine(" Very Good");
                else if (grade == 'B' || grade == 'b')
                    Console.WriteLine("Good");
            else if (grade == 'C' || grade == 'c')
                Console.WriteLine("Good");
            else
                Console.WriteLine("Invalid grade");




        }

        public void CheckGradeSwitch()
        {
            char grade;
            Console.WriteLine("Enter your Grade");
            grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'o':
                case 'O':
                    Console.WriteLine("Excellent");
                    break;
                case 'A':
                case 'a':
                    Console.WriteLine(" Very Good");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Can improve");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;


            }
        }
    }
}
