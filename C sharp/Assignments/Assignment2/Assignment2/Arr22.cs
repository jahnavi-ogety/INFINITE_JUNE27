using System;


namespace Assignment2
{
    class Arr22
    {
        public static void Main()
        {       
               const int Marks = 10;
                int[] marks = new int[Marks];
                Console.WriteLine($"Enter {Marks} marks:");

                for (int j = 0; j < Marks; j++)
                {
                    Console.Write($"Mark {j + 1}: ");
                    marks[j] = Convert.ToInt32(Console.ReadLine());
                }
                int total = 0;
                foreach (int mark in marks)
                {
                    total += mark;
                }
                double average = (double)total / Marks;
                int minMark = marks[0];
                int maxMark = marks[0];

                for (int i = 1; i < Marks; i++)
                {
                    if (marks[i] < minMark)
                    {
                        minMark = marks[i];
                    }
                    if (marks[i] > maxMark)
                    {
                        maxMark = marks[i];
                    }
                }       
                Array.Sort(marks);
                Array.Reverse(marks);
                Console.WriteLine();
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Average: {average:A2}");
                Console.WriteLine($"Minimum Mark: {minMark}");
                Console.WriteLine($"Maximum Mark: {maxMark}");

                Console.WriteLine();
                Console.WriteLine("Marks in ascending order:");
                foreach (var mark in marks)
                {
                    Console.Write($"{mark} ");
                }

                Console.WriteLine();
                Console.WriteLine("Marks in descending order:");
                foreach (var mark in marks)
                {
                    Console.Write($"{mark} ");
                }

                Console.WriteLine();
            Console.Read();
            }
        }

    }


