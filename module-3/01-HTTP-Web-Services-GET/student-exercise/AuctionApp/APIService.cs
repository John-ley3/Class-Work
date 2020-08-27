using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionApp
{
    public class APIService
    {
        private readonly string API_URL = "http://localhost:3000/";
        private readonly RestClient client = new RestClient();

        public List<Auction> GetAllAuctions()
        {
            RestRequest request = new RestRequest(API_URL + "auctions");
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            else
            {
                return null;
            }
        }

        public Auction GetDetailsForAuction(int auctionId)
        {
            RestRequest request = new RestRequest(API_URL + "auctions/" + auctionId);
            IRestResponse<Auction> response = client.Get<Auction>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            else
            {
                return null;
            }
        }

        public List<Auction> GetAuctionsSearchTitle(string searchTitle)
        {
            RestRequest request = new RestRequest(API_URL + "auctions/" + "?title_like=" + searchTitle);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            else
            {
                return null;
            }
        }

        public List<Auction> GetAuctionsSearchPrice(double searchPrice)
        {
            RestRequest request = new RestRequest(API_URL + "auctions/" + "?currentBid_lte=" + searchPrice);
            IRestResponse<List<Auction>> response = client.Get<List<Auction>>(request);
            if (CheckResponse(response))
            {
                return response.Data;
            }
            else
            {
                return null;
            }
        }

        private bool CheckResponse(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                Console.WriteLine("Error occured... Connection to the server was not established");
            }
            else if (!response.IsSuccessful)
            {
                Console.WriteLine("Request to server was unsuccessful");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
