using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    public class Card
    {
        /// <summary>
        /// Constructor for Card that sets value and suit
        /// </summary>
        /// <param name="value">The value of the card</param>
        /// <param name="suit">The suit of the card</param>
        public Card(int Value, string suit)
        {
            // this refers to items in the object
            this.Value = Value;
            Suit = suit;
        }
        /// <summary>
        /// Another constructor, this requires face up
        /// </summary>
        /// <param name="value">The value of the card</param>
        /// <param name="suit">The suit of the card</param>
        /// <param name="isFaceUp">Whether the card is face up</param>
        // Overload the constructor to take in more information about the card
        public Card(int value, string suit, bool isFaceUp)
        {
            Value = value;
            Suit = suit;
            IsFaceUp = isFaceUp;
        }
        /// <summary>
        /// The numeric value for the card.
        /// </summary>
        // Remove the setter (set;) so this value can only be set through the constructor
        public int Value { get; }
        /// <summary>
        /// The card's suit
        /// </summary>
        // Remove the setter (set;) so this value can only be set through the constructor
        public string Suit { get; }
        /// <summary>
        /// The state of the card's display
        /// </summary>
        // Make the setter private so this value can only be changed through the Flip method
        public bool IsFaceUp { get; private set; }
        /// <summary>
        /// Stores the color of the card
        /// </summary>
        //derived property: calculated from the Suit
        public string Color { 
            get
            {
                if(Suit == "Hearts" || Suit == "Diamonds")
                {
                    return "Red";
                } else
                {
                    return "Black";
                }
            }
        }

        public void Flip()
        {
            if(IsFaceUp)
            {
                IsFaceUp = false;
            } else
            {
                IsFaceUp = true;
            }
        }
    }
}
