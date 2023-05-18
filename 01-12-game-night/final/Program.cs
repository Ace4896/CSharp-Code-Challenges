using System;
using System.Collections.Generic;
using System.Linq;

namespace gamenight
{
    class MainClass
    {
        public static List<Player> players = new List<Player>()
        {
            new Player("Douglas", "Flores", 233, 198),
            new Player("Kathryn", "Flores", 219, 202),
            new Player("Robin", "Flores", 241, 222),
            new Player("James", "Ortiz", 144, 198),
            new Player("Sharon", "Ortiz", 233, 198),
            new Player("Jack", "Wagner", 189, 234),
            new Player("Amanda", "Wagner", 211, 178)
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter an improvement index to see which game night attendees fit the bill:");
            var targetImprovement = int.Parse(Console.ReadLine());

            // MARK: Result
            PrintStats(targetImprovement);
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void PrintStats(int targetImprovement)
        {
            // 1
            var gameQuery =
                from player in players
                    // 2
                let improvement = player.currentScore - player.lastScore
                // 3
                where improvement > targetImprovement && improvement > 0
                // 4
                group player by player.lastname[0] into playerGroup
                // 5
                orderby playerGroup.Key
                // 6
                select playerGroup;

            // 7
            foreach (var playerGroup in gameQuery)
            {
                Console.WriteLine("\n" + playerGroup.Key);
                foreach (var player in playerGroup)
                {
                    Console.WriteLine($"{player.firstname} {player.lastname} improved by more than {targetImprovement}!");
                }
            }
        }
    }
}