using System;
using System.Collections.Generic;

namespace countingvowels
{
    class MainClass
    {
        public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Type in a word or phrase to find it's vowel score:");
            string input = Console.ReadLine().ToLower();

            // MARK: Result
            Console.WriteLine($"Score: {VowelCount(input)}");
            Console.ReadKey();
        }

        // MARK: Calculation
        public static int VowelCount(string text)
        {
            // 1
            int totalScore = 0;

            // 2
            for (int i = 0; i < text.Length; i++)
            {
                // 3
                int points = 0;
                if (vowelScores.TryGetValue(text[i], out points))
                {
                    totalScore += points;
                }
            }

            // 4
            return totalScore;
        }
    }
}