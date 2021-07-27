using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deckRanks = new List<string>() { };
            deckRanks.Add("Ace ");
            deckRanks.Add("2 ");
            deckRanks.Add("3 ");
            deckRanks.Add("4 ");
            deckRanks.Add("5 ");
            deckRanks.Add("6 ");
            deckRanks.Add("7 ");
            deckRanks.Add("8 ");
            deckRanks.Add("9 ");
            deckRanks.Add("10 ");
            deckRanks.Add("Jack ");
            deckRanks.Add("Queen ");
            deckRanks.Add("King ");

            var deckSuits = new List<string>() { };
            deckSuits.Add("of Clubs");
            deckSuits.Add("of Diamonds");
            deckSuits.Add("of Hearts");
            deckSuits.Add("of Spades");

            var deck = new List<string>() { };

            Console.WriteLine();
            foreach (string card in deckRanks)
            {
                foreach (string aCard in deckSuits)
                {
                    Console.WriteLine($"{card}{aCard}");
                }
            }
        }
    }
}
