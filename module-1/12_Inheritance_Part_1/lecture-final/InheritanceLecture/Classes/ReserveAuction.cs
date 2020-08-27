using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Classes
{
    public class ReserveAuction : Auction
    {
        private decimal reservePrice { get; }
        public ReserveAuction(decimal reservePrice)
        {
            this.reservePrice = reservePrice;
        }

        public override bool PlaceBid(Bid offered)
        {
            bool isCurrentHighBid = false;
            // Only consider bids that are over or equal to the reserve
            if(offered.BidAmount >= reservePrice)
            {
                isCurrentHighBid = base.PlaceBid(offered);
            } else
            {
                allBids.Add(offered);
                Console.WriteLine("Reserve has not been met " + offered.NameOfBidder);
            }
            return isCurrentHighBid;
        }
    }
}
