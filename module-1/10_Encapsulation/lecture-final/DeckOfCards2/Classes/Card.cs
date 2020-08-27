using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DeckOfCards2.Classes
{
    public class Card
    {
        private const string FACEDOWNNOTE = "Card is Face Down";
        /// <summary>
        /// Constructor for Card that sets value and suit
        /// </summary>
        /// <param name="value">The value of the card</param>
        /// <param name="suit">The suit of the card</param>
        public Card(int GivenValue, string suit)
        {
            // this refers to items in the object
            this.Value = GivenValue;
            Suit = suit;
        }
        /// <summary>
        /// Another constructor, this requires face up
        /// </summary>
        /// <param name="value">The value of the card</param>
        /// <param name="suit">The suit of the card</param>
        /// <param name="isFaceUp">Whether the card is face up</param>
        // Overload the constructor to take in more information about the card
        public Card(int givenValue, string suit, bool isFaceUp)
        {
            Value = givenValue;
            Suit = suit;
            IsFaceUp = isFaceUp;
        }
        /// <summary>
        /// The numeric value for the card.
        /// </summary>
        // Remove the setter (set;) so this value can only be set through the constructor
        private int _Value { get; set; }
        public int Value
        {
            get
            {
                if (!IsFaceUp)
                {
                    return -1;
                }
                else
                {
                    return _Value;

                }
            }
            set
            {
                if (value > 13 || value < 0)
                {
                    _Value = 0;
                }
                else
                {
                    _Value = value;
                }
            }
        }
        /// <summary>
        /// The card's suit
        /// </summary>
        // Remove the setter (set;) so this value can only be set through the constructor
        private string _Suit { get; set; }
        public string Suit
        {
            get
            {
                return IsFaceUp ? _Suit : FACEDOWNNOTE;
            }
            set
            {
                if(suitNames.Contains(value))
                {
                    _Suit = value;
                }
            }
        }
        /// <summary>
        /// The state of the card's display
        /// </summary>
        // Make the setter private so this value can only be changed through the Flip method
        public bool IsFaceUp { get; private set; }
        /// <summary>
        /// Stores the color of the card
        /// </summary>
        //derived property: calculated from the Suit
        public string Color
        {
            get
            {
                if (Suit == "Hearts" || Suit == "Diamonds")
                {
                    return "Red";
                }
                else
                {
                    return "Black";
                }
            }
        }

        public void Flip()
        {
            if (IsFaceUp)
            {
                IsFaceUp = false;
            }
            else
            {
                IsFaceUp = true;
            }
        }
        public void Flip(bool shouldBeFaceUp)
        {
            IsFaceUp = shouldBeFaceUp;
        }
        public string FaceValue
        {
            get
            {
                return IsFaceUp ? faceValues[_Value] : FACEDOWNNOTE;
            }
        }
        /// <summary>
        /// Holds all possible values and text representations of a card
        /// </summary>
        private Dictionary<int, string> faceValues = new Dictionary<int, string>()
        {
            {0,"Unknown" },
            {1,"Ace" },
            {2,"Deuce" },
            {3,"Three" },
            {4, "Four" },
            {5, "Five" },
            {6, "Six" },
            {7, "Seven" },
            {8, "Eight" },
            {9, "Nine" },
            {10, "Ten" },
            {11, "Jack" },
            {12, "Queen" },
            {13, "King" }
        };
        /// <summary>
        /// Static means it is a member of the CLASS not the object
        /// </summary>
        public static List<string> suitNames = new List<string>()
        {
            "Spades","Diamonds","Hearts","Clubs"
        };

        public char Symbol
        {
            get
            {
                if (!Suit.Contains(FACEDOWNNOTE))
                {
                    // Since the static property is from the class, you don't need Card.
                    return suitSymbols[Suit];
                }
                return ' ';
            }
        }
        static Dictionary<string, char> suitSymbols = new Dictionary<string, char>()
        {
            {"Spades", '\u2660' },
            {"Diamonds",'\u2666' },
            {"Clubs",'\u2663' },
            {"Hearts",'\u2665' }
        };

    }
}
