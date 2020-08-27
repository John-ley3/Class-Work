using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Classes
{
    public class Auction
    {
        /// <summary>
        /// Holds all the bids made in this auction
        /// </summary>
        protected List<Bid> allBids = new List<Bid>();
        public Bid[] AllBids
        {
            get
            {
                return allBids.ToArray();
            }
        }
        public Bid CurrentHighBid { get; set; } = new Bid(null,0M);
        /// <summary>
        /// Holds boolean to track auction in progress
        /// </summary>
        public bool HasEnded { get; private set; }
        /// <summary>
        /// Places a bid in the auction
        /// </summary>
        /// <param name="offeredBid">The bid to place</param>
        /// <returns>True if bid is successful (highest), false if bid fails</returns>
        public virtual bool PlaceBid(Bid offeredBid)
        {
            // Add the new bid to the list allBids for tracking
            allBids.Add(offeredBid);

            // Check if it is a winning bid by comparing to CurrentHighBid
            bool isCurrentWinningBid = false;
            if(offeredBid.BidAmount > CurrentHighBid.BidAmount)
            {
                // if yes, our bid is successful
                CurrentHighBid = offeredBid;
                isCurrentWinningBid = true;
            }

            // Output the current high bid
            Console.WriteLine("Current high bid is " + CurrentHighBid.NameOfBidder + " for $" + CurrentHighBid.BidAmount);
            Console.WriteLine();

            return isCurrentWinningBid;
        }
        public void EndAuction ()
        {
            HasEnded = true;
            Console.WriteLine($"The auction is over. The winning bid was made by {CurrentHighBid.NameOfBidder} for {CurrentHighBid.BidAmount:C2}.");
        }
    }
}
