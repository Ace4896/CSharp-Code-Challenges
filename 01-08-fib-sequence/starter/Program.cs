using System;
using System.Collections.Generic;

namespace fibsequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibonacci(input);
            Console.WriteLine(string.Join(' ', sequence));

            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            /*
             * Criteria:
             * - First two numbers must be 0 and 1
             * - Each Fibonacci number is the sum of the two previous numbers
             */

            // Additional check to make sure we don't construct an empty or invalid sequence
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length), "length must be positive");
            }

            if (length == 1)
            {
                return new List<int>() { 0 };
            }

            List<int> sequence = new() { 0, 1 };
            for (int i = 2; i < length; i++)
            {
                int fibNumber = sequence[i - 2] + sequence[i - 1];
                sequence.Add(fibNumber);
            }

            return sequence;
        }
    }
}