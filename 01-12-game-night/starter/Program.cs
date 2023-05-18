using System;
using System.Collections.Generic;
using System.Linq;

namespace gamenight
{
    class MainClass
    {
        public static List<Player> players = new List<Player>()
        {
            new Player("Harrison", "Ferrone", 233, 198),
            new Player("Alex", "Ferrone", 219, 202),
            new Player("Haley", "Ferrone", 241, 222),
            new Player("John", "Doe", 144, 198),
            new Player("Sally", "Doe", 233, 198),
            new Player("Frank", "Smith", 189, 234),
            new Player("Joan", "Smith", 211, 178)
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
            /*
             * Criteria:
             * - Group the players by surname initial
             * - For each group, output which players have improved by the specified threshold
             */
            var playerGroups = players
                .Where(player => player.currentScore - player.lastScore > targetImprovement)
                .GroupBy(player => player.lastname[0])
                .OrderBy(group => group.Key);

            foreach (var playerGroup in playerGroups)
            {
                // The initial for each surname
                Console.WriteLine(playerGroup.Key);

                // Each player in this group
                foreach (Player player in playerGroup)
                {
                    Console.WriteLine($"{player.firstname} {player.lastname} improved by more than {targetImprovement}!");
                }
            }
        }
    }
}