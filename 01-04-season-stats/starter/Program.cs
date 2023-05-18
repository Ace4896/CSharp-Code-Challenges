using System;
using System.Collections.Generic;

namespace seasonstats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<int> scores = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            // MARK: Result
            PrintStats(scores);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void PrintStats(List<int> scores)
        {
            /*
             * Given the scores, calculate:
             * - Lowest and highest values
             * - Sum
             * - Average
             */

            // While all of this can be done using separate LINQ statements, it's more efficient to loop over the list once
            if (scores.Count == 0)
            {
                Console.WriteLine("No scores provided");
                return;
            }

            int lowest = scores[0];
            int highest = scores[0];
            int sum = scores[0];

            for (int i = 1; i < scores.Count; i++)
            {
                sum += scores[i];

                if (scores[i] < lowest)
                {
                    lowest = scores[i];
                }

                if (scores[i] > highest)
                {
                    highest = scores[i];
                }
            }

            decimal average = (decimal)sum / scores.Count;

            Console.WriteLine($"Lowest: {lowest}");
            Console.WriteLine($"Highest: {highest}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F3}");
        }
    }
}