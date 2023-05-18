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
            CalculateTip(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void CalculateTip(int cost)
        {
            /*
             * Criteria:
             * - Return value needs to be a single type
             * - Tip percentages are 10%, 17.5% and 25%.
             */
            Tip tip = new(cost, 10.0M, 17.5M, 25.0M);
            Console.WriteLine($"Low ({tip.LowTipPercentage}%) -> {tip.LowTip:C2}");
            Console.WriteLine($"Medium ({tip.MediumTipPercentage}%) -> {tip.MediumTip:C2}");
            Console.WriteLine($"High ({tip.HighTipPercentage}%) -> {tip.HighTip:C2}");
        }
    }

    // Separate class seems a bit overkill...
    class Tip
    {
        public int Cost { get; }
        public decimal LowTipPercentage { get; }
        public decimal MediumTipPercentage { get; }
        public decimal HighTipPercentage { get; }

        public decimal LowTip { get; }
        public decimal MediumTip { get; }
        public decimal HighTip { get; }

        public Tip(int cost, decimal lowTipPercentage, decimal mediumTipPercentage, decimal highTipPercentage)
        {
            Cost = cost;
            LowTipPercentage = lowTipPercentage;
            MediumTipPercentage = mediumTipPercentage;
            HighTipPercentage = highTipPercentage;

            LowTip = CalculateTip(cost, LowTipPercentage);
            MediumTip = CalculateTip(cost, MediumTipPercentage);
            HighTip = CalculateTip(cost, HighTipPercentage);
        }

        private static decimal CalculateTip(int cost, decimal tipPercentage) => cost * tipPercentage / 100.0M;
    }
}
