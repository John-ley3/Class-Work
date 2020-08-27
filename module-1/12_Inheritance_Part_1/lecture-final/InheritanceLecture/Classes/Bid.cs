using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Classes
{
    public class Bid
    {
        /// <summary>
        /// Holds the name of the Bidder
        /// </summary>
        public string NameOfBidder { get; }
        /// <summary>
        /// The bid amount. I think decimal for money, but whole dollars could be an int
        /// </summary>
        public decimal BidAmount { get; }

        public Bid(string nameOfBidder, decimal bidAmount)
        {
            NameOfBidder = nameOfBidder;
            BidAmount = bidAmount;
        }

    }
}
