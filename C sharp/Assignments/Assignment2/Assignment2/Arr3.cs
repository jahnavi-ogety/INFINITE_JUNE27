using System;


namespace Assignment2
{
    class Arr3
    {
        public static void Main()
        {   
                int[] array = { 1, 5, 4, 3, 16, 8, 3, 6, 2, 9 };

                double average = CalAverage(array);

                int minArray = FindMinimum(array);
                int maxArray = FindMax(array);

                
                Console.WriteLine($"Original Array: [{string.Join(", ", array)}]");
                Console.WriteLine($"Average value of Array elements: {average:F2}");
                Console.WriteLine($"Minimum value in Array: {minArray}");
                Console.WriteLine($"Maximum value in Array: {maxArray}");
                Console.Read();
            }

            
            static double CalAverage(int[] array)
            {
                if (array.Length == 0)
                {
                    return 0;
                }

                int total = 0;
                foreach (int num in array)
                {
                    total += num;
                }

                return (double)total / array.Length;
            }

            static int FindMinimum(int[] array)
            {
                if (array.Length == 0)
                {
                    throw new ArgumentException("Array must not be empty");
                }

                int min = array[0];
                foreach (int num in array)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            }

            static int FindMax(int[] array)
            {
                if (array.Length == 0)
                {
                    throw new ArgumentException("Array must not be empty");
                }

                int max = array[0];
                foreach (int num in array)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }

                return max;
            }
        }
}    
    

