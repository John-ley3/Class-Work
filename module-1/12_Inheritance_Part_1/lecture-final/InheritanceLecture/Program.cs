using InheritanceLecture.Classes;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our general Auction");
            Console.WriteLine("------------------------------");

            Auction generalAuction = new Auction();
            Bid bid1 = new Bid("Henry Edwards", 10M);
            Bid bid2 = new Bid("Mimi Malone", 15M);

            generalAuction.PlaceBid(bid1);
            generalAuction.PlaceBid(bid2);
            generalAuction.PlaceBid(new Bid("Mimi Malone",25M));
            generalAuction.PlaceBid(new Bid("Henry Edwards", 5M));
            generalAuction.EndAuction();

            // list all bids
            for(int i = 0; i < generalAuction.AllBids.Length; i++)
            {
                Console.WriteLine($"Bid number {i + 1} is from {generalAuction.AllBids[i].NameOfBidder} for {generalAuction.AllBids[i].BidAmount}");
            }

            Console.WriteLine("Welcome to our Reserve Auction");
            Console.WriteLine("------------------------------");

            ReserveAuction reserveAuction = new ReserveAuction(100M);

            reserveAuction.PlaceBid(bid1);
            reserveAuction.PlaceBid(new Bid("Henry Edwards", 110M));

            Console.WriteLine("Welcome to our Buy Out Auction");
            Console.WriteLine("------------------------------");

            BuyoutAuction buyoutAuction = new BuyoutAuction(200M);

            buyoutAuction.PlaceBid(new Bid("Henry Edwards", 110M));
            buyoutAuction.PlaceBid(new Bid("Mimi Malone", 150M));
            buyoutAuction.PlaceBid(new Bid("Henry Edwards", 175M));
            buyoutAuction.PlaceBid(new Bid("Mimi Malone", 250M));
            buyoutAuction.PlaceBid(new Bid("Henry Edwards", 350M));
        }
    }
}
