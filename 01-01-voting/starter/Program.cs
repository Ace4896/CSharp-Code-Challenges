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
            var presidents = CalculatePresidents(input);
            Console.WriteLine($"You've voted for {presidents} presidents!");
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static int CalculatePresidents(int age)
        {
            /*
             * Example: age = 32
             * - Been voting for 32 - 18 = 14 years
             * - Each voting term is 4 years
             * - Number of times they've voted is 14 / 4 = 3 voting terms
             * 
             * Example: age = 18
             * - Not old enough to vote
             */
            const int votingAge = 18;       // Minimum age for voting
            const int votingTermYears = 4;  // Number of years in each voting term

            int eligibleYears = age - votingAge;
            if (eligibleYears <= 0)
            {
                Console.WriteLine("Not old enough to vote");
                return 0;
            }

            // Sample solution seemed to use modulo, but I don't think it was necessary?
            // They were counting how many times eligibleYears % 4 == 0, which is the same as just dividing...
            return eligibleYears / votingTermYears;
        }
    }
}
