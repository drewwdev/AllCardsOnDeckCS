using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ranks = new List<string>() { };
            Ranks.Add("Ace");
            Ranks.Add("2");
            Ranks.Add("3");
            Ranks.Add("4");
            Ranks.Add("5");
            Ranks.Add("6");
            Ranks.Add("7");
            Ranks.Add("8");
            Ranks.Add("9");
            Ranks.Add("10");
            Ranks.Add("Jack");
            Ranks.Add("Queen");
            Ranks.Add("King");

            var Suits = new List<string>() { };
            Suits.Add("Clubs");
            Suits.Add("Diamonds");
            Suits.Add("Hearts");
            Suits.Add("Spades");

            var deck = new List<string>() { };

            Console.WriteLine();
            foreach (string rank in Ranks)
            {
                foreach (string suit in Suits)
                {
                    deck.Add($"{rank} of {suit}");
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
