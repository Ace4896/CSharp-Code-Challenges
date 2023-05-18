using System;
using System.Collections.Generic;
using System.Linq;

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
            // NOTE: This can be done with fewer intermediate hash sets, but it seemed better to treat them as immutable
            HashSet<string> combinedSet = family.Concat(friends).ToHashSet();
            HashSet<string> duplicatesSet = family.Intersect(friends).ToHashSet();
            HashSet<string> rsvpSet = rsvp.ToHashSet();
            List<string> missingRsvp = combinedSet.Except(rsvpSet).ToList();

            Console.WriteLine($"Total Invites: {combinedSet.Count}");
            Console.WriteLine($"{duplicatesSet.Count} Duplicate(s): {string.Join(", ", duplicatesSet)}");
            Console.WriteLine($"Missing RSVPs: {string.Join(", ", missingRsvp)}");
        }
    }
}