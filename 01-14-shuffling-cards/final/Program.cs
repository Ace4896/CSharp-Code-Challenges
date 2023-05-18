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
            Deal(new Stack<string>(shuffledDeck));

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<string> Shuffle(List<string> deck)
        {
            // 1
            Random random = new Random();

            // 2
            for (int i = 0; i < deck.Count; i++)
            {
                // 3
                int randomIndex = random.Next(i, deck.Count);

                // 4
                string tempCard = deck[i];
                
                // 5
                deck[i] = deck[randomIndex];

                // 6
                deck[randomIndex] = tempCard;
            }

            return deck;
        }

        // MARK: Optional functionality
        public static void Deal(Stack<string> shuffledDeck)
        {
            Console.WriteLine("Your hand:");
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"  -> {shuffledDeck.Pop()}");
            }

            Console.WriteLine("\nBurned top card...");
            var burn = shuffledDeck.Pop();

            Console.WriteLine("\nHole cards:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"  -> {shuffledDeck.Pop()}");
            }

            Console.WriteLine("\nBetting starts!");
        }
    }
}