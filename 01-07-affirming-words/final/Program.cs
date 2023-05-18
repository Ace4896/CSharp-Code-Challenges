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

        // 1
        static Timer timer;

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
        }

        // MARK: Write your solution here...
        public static void StartTimer(int interval)
        {
            // 2
            int milliseconds = interval * 1000;
            timer = new Timer(milliseconds);

            // 3
            timer.Elapsed += OnTimerEvent;

            // 4
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        // 5
        private static void OnTimerEvent(Object source, ElapsedEventArgs e)
        {
            int index = random.Next(4);
            Console.WriteLine(encouragements[index]);
        }

        // 6
        public static void StopTimer()
        {
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("Time stopped");
        }
    }
}