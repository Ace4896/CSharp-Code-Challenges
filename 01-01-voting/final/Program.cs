using System;

namespace voting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("How old are you?");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            int presidents = CalculatePresidents(input);
            Console.WriteLine($"You've voted for {presidents} presidents!");
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static int CalculatePresidents(int age)
        {
            // 1
            int eligibleYears = age - 18;
            int presidents = 0;

            // 2
            if (eligibleYears <= 0)
            {
                Console.WriteLine("Looks like you're not old enough to vote yet.");
                return 0;
            }

            // 3
            for (int i = 1; i <= eligibleYears; i++)
            {
                // 4
                if (i % 4 == 0)
                {
                    presidents++;
                }
            }

            // 5
            return presidents;
        }
    }
}