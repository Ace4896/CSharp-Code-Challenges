using System;

namespace tipcalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = int.Parse(Console.ReadLine());

            // MARK: Result
            var tips = CalculateTip(input);
            Console.WriteLine($"\n10% -> ${tips.low} \n17.5% -> ${tips.mid} \n25% -> ${tips.high}");
            Console.ReadKey();
        }

        // MARK: Write your solution here
        // 1
        public static (string low, string mid, string high) CalculateTip(int cost)
        {
            // 2
            string lowTiper = Math.Round(cost * 0.10, 2).ToString("#.00");
            string mediumTip = Math.Round(cost * 0.175, 2).ToString("#.00");
            string highTipper = Math.Round(cost * 0.25, 2).ToString("#.00");

            // 3
            return (lowTiper, mediumTip, highTipper);
        }
    }
}