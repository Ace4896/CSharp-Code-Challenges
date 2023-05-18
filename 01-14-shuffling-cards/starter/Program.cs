using System;
using System.Collections.Generic;

namespace shufflingcards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
            Console.ReadKey();

            // MARK: Result
            var freshDeck = new Deck();
            var shuffledDeck = Shuffle(freshDeck.cards);

            // Deal the first 5 cards in the deck
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(shuffledDeck[i]);
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<string> Shuffle(List<string> deck)
        {
            List<string> shuffledDeck = new(deck);

            // This method of shuffling a deck is really simple - just swap a few values around
            // There are better algorithms for shuffling, but they're outside the scope of this challenge
            for (int i = 0; i < 10000; i++)
            {
                int firstIndex = Random.Shared.Next(deck.Count);
                int secondIndex = Random.Shared.Next(deck.Count);

                // VS gave a simplification hint for swapping two values - pretty cool!
                (shuffledDeck[secondIndex], shuffledDeck[firstIndex]) = (shuffledDeck[firstIndex], shuffledDeck[secondIndex]);
            }

            return shuffledDeck;
        }
    }
}