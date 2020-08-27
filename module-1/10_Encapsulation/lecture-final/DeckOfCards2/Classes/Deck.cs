using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards2.Classes
{
    public class Deck
    {
        private List<Card> AllCards { get; set; } = new List<Card>();
        private int _numberOfCards { get; }
        public int NumberOfCards { get { return _numberOfCards; } }

        /// <summary>
        /// Default constructor to populate the deck
        /// </summary>
        public Deck()
        {
            foreach (string suit in Card.suitNames)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card card = new Card(i, suit);
                    AllCards.Add(card);
                }
            }
            _numberOfCards = AllCards.Count;
        }

        public Card DealOneFaceUp()
        {
            // Get the top card
            return DealOneCard(true);
        }
        public Card DealOneFaceDown()
        {
            // Get the top card
            return DealOneCard(false);
        }

        // Helper function
        private Card DealOneCard(bool shouldBeFaceUp)
        {
            Card drawnCard = null;
            if(AllCards.Count > 0)
            {
                drawnCard = AllCards[0];
                drawnCard.Flip(shouldBeFaceUp);
                AllCards.Remove(drawnCard);
            }
            return drawnCard;

        }

        public List<Card> DealHandOfFive()
        {
            List<Card> output = new List<Card>();
            for(int i =0;i < 5;i++)
            {
                output.Add(DealOneCard(true));
            }
            return output;
        }

        public void Shuffle()
        {
            Random r = new Random();
            for(int i = 0; i < 1000000; i++)
            {
                int randomSpot1 = r.Next(0, AllCards.Count - 1);
                int randomSpot2 = r.Next(0, AllCards.Count - 1);
                // need swap the cards at those spots
                Card temp = AllCards[randomSpot1];
                AllCards[randomSpot1] = AllCards[randomSpot2];
                AllCards[randomSpot2] = temp;
            }
        }
    }
}
