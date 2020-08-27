using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Classes
{
    public class BuyoutAuction : Auction
    {
        private decimal buyOutPrice { get; }
        public BuyoutAuction(decimal buyOutPrice)
        {
            this.buyOutPrice = buyOutPrice;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentHighBid = false;

            // Bid only if the auction is still active
            if(!HasEnded)
            {
                // if it is higher than the buyOutPrice
                if(offeredBid.BidAmount >= buyOutPrice)
                {
                    // log the bid
                    // Nice, only accept the amount of buyout
                    Bid buyoutBid = new Bid(offeredBid.NameOfBidder, buyOutPrice);
                    // place bid
                    isCurrentHighBid = base.PlaceBid(buyoutBid);
                    Console.WriteLine("Buyout met by " + offeredBid.NameOfBidder);
                    // end the auction
                    EndAuction();
                } else
                {
                    // At least check to see if bid is higher than all other bids placed
                    isCurrentHighBid = base.PlaceBid(offeredBid);

                }
            } else
            {
                Console.WriteLine("You're too late");
            }
            return isCurrentHighBid;
        }
    }
}
