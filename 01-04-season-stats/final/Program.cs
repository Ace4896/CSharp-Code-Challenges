using System;
using System.Collections.Generic;
using System.Linq;

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

        // MARK: Calculation
        public static void PrintStats(List<int> scores)
        {
            // 1
            scores.Sort();

            // 2
            int lowest = scores[0];
            Console.WriteLine($"\nLowest scoring game \t-> {lowest}");

            // 3
            int highest = scores[scores.Count - 1];
            Console.WriteLine($"Highest scoring game \t-> {highest}");

            // 4
            int sum = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                sum += scores[i];
            }

            Console.WriteLine($"Total season points \t-> {sum}");

            // 5
            Console.WriteLine($"Average points/game \t-> {sum / scores.Count}");

            // Optional - LINQ
            //int lowestLINQ = scores.First();
            //int highestLINQ = scores.Last();
            //int sumLINQ = scores.Sum();
            //double averageLINQ = scores.Average();
        }
    }
}