using DeckOfCards2.Classes;
using System;
using System.Collections.Generic;

namespace DeckOfCards2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Card card = new Card(12, "Moons",true);
            Card faceUpCard = new Card(11, "Diamonds",true);
            Deck deck = new Deck();

            for(int i = 0; i < deck.NumberOfCards; i++)
            {
                Card dealtCard = deck.DealOneFaceDown();
                Console.WriteLine($"{dealtCard.FaceValue} of {dealtCard.Suit} ");
            }

            deck = new Deck();
            deck.Shuffle();
            List<Card> hand = deck.DealHandOfFive();
            foreach(Card cardInHand in hand)
            {
                Console.WriteLine($"{cardInHand.FaceValue} of {cardInHand.Suit} {cardInHand.Symbol} ");
            }
            Console.WriteLine(card.FaceValue);
            Console.WriteLine(faceUpCard.FaceValue);
            Console.WriteLine("Hello World!");
        }
    }
}
