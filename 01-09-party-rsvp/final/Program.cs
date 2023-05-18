using System;
using System.Collections.Generic;

namespace partyrsvp
{
    class MainClass
    {
        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            // MARK: Result
            InviteDetails();
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void InviteDetails()
        {
            // 1
            HashSet<string> everyone = new HashSet<string>(family);

            // 2
            everyone.UnionWith(friends);

            // 3
            Console.WriteLine($"You sent out {everyone.Count} invites total!\n");

            // 4
            Console.WriteLine($"Duplicates sent to:");
            HashSet<string> duplicates = new HashSet<string>(family);

            // 5 
            duplicates.IntersectWith(friends);
            PrintSets(duplicates);

            // 6
            Console.WriteLine("People who haven't responded yet:");
            everyone.SymmetricExceptWith(rsvp);
            PrintSets(everyone);
        }

        // MARK: Utilities
        public static void PrintSets(HashSet<string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine($"  -> {name}");
            }

            Console.WriteLine();
        }
    }
}