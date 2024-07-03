using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    public class Cricket
    {
        public int[] scores;



        public void Pointscalculation(int no_of_matches)
        {
            scores = new int[no_of_matches];


            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter the score for match {i + 1}: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }


            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"sum of the match is: {sum}");
            Console.WriteLine($"average of the match  is: {average}");
        }
    }

    class Program_1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of matches: ");
            int matches_played = Convert.ToInt32(Console.ReadLine());

            Cricket cricket = new Cricket();
            cricket.Pointscalculation(matches_played);
            Console.ReadLine();
        }
    }
}
