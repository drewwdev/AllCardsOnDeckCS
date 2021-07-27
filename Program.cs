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
            foreach (string rank in deckRanks)
            {
                foreach (string suit in deckSuits)
                {
                    deck.Add($"{rank}{suit}");
                }
            }

            var numberOfCards = deck.Count;
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                var leftCard = deck[leftIndex];
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }

            var firstCard = deck[51];
            var secondCard = deck[50];
            Console.WriteLine($"Your first card is {firstCard} and your second card is {secondCard}");

            var playerHand = new List<string>() { };
            playerHand.Add(firstCard);
            deck.Remove(firstCard);
            playerHand.Add(secondCard);
            deck.Remove(secondCard);
            Console.WriteLine($"Player hand now holds {playerHand[0]} and {playerHand[1]} and the deck now contains {deck.Count} cards");
        }
    }
}
