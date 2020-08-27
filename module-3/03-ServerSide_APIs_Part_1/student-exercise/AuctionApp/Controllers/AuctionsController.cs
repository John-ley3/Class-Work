using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> GetAuctions(string title_like = "", double currentBid_lte = 0)
        {
            if(title_like != "" && currentBid_lte != 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if(title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            else if(currentBid_lte != 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            return dao.List();
        }

        [HttpGet("{id}")]
        public Auction GetAuctionsById(int id)
        {
            Auction auction = dao.Get(id);

            if(auction != null)
            {
                return auction;
            }

            return null;
        }

        [HttpPost]
        public Auction AddAuction(Auction auction)
        { 
            return dao.Create(auction);
        }
    }
}
