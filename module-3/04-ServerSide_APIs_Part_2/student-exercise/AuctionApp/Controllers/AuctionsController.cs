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
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction added = dao.Create(auction);

            return Created($"/auction/{added.Id}", added);
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(Auction auctionToUpdate, int id)
        {
            Auction existingAuction = dao.Get(id);

            if(existingAuction == null)
            {
                return NotFound("Auction does not exist. Try Again?");
            }

            Auction result = dao.Update(auctionToUpdate.Id.Value, auctionToUpdate);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Auction existingAuction = dao.Get(id);
            if(existingAuction == null)
            {
                return NotFound("Auction does not exist. Try Again?");
            }
            bool didDelete = dao.Delete(id);

            if(didDelete)
            {
                return NoContent();
            }
            return StatusCode(500);
        }
    }
}
