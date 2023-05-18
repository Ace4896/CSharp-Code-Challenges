using System;
using System.Collections.Generic;
using System.Timers;

namespace affirmingwords
{
    class MainClass
    {
        static Random random = new Random();
        static List<string> encouragements = new List<string>()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        static Timer? timer = null;
        static int intervals = 0;

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to start the timer!");
            Console.ReadLine();

            // MARK: Result
            StartTimer(3);

            Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
            Console.ReadLine();
            StopTimer();

            Console.WriteLine("Timer stopped; press any key to exit");
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void StartTimer(int interval)
        {
            if (timer != null)
            {
                timer.Dispose();
            }

            // Interval is provided in seconds, but needs to be milliseconds
            timer = new Timer(interval * 1000);

            // NOTE: Static state isn't ideal, but left this in as this is a simple example
            // Should have a class that wraps the timer itself and the number of events
            timer.Elapsed += (_, e) =>
            {
                intervals++;
                int elapsed = intervals * interval;
                string encouragement = encouragements[random.Next(encouragements.Count)];

                Console.WriteLine($"{elapsed} seconds -> {encouragement}");
            };

            timer.Start();
        }

        // 6
        public static void StopTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
        }
    }
}